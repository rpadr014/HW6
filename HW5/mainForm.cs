using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace HW5
{
    public partial class mainForm : Form
    {
        private string fileName = "";
        private bool edited = false;
        public Shape features = new Shape();

        public mainForm()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (edited == true)
            {
                var res = MessageBox.Show("Do you want to save changes?", "Changes detected!", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if (res == DialogResult.No)
                {
                    Shape newfeatures = new Shape();
                    features = newfeatures;
                    statusLabel.Text = "New document created.";
                    this.Text = "New Document";
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                serializer();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "soap files|*.soap";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                serializer();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                try
                {
                    SoapFormatter formatter = new SoapFormatter();
                    Shape newfeatures = (Shape)formatter.Deserialize(fs);
                    features = newfeatures;
                    loadFeatures(features);
                    statusLabel.Text = fileName + " was opened.";
                    this.Text = fileName;
                }
                catch (SerializationException er)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + er.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        private void serializer()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            SoapFormatter formatter = new SoapFormatter();

            try
            {
                features.Size = new Size(this.Size.Width, this.Size.Height);
                features.Location = new Point(this.Location.X, this.Location.Y);
                features.textTitle = fileName;
                formatter.Serialize(fs, features);
                statusLabel.Text = fileName + " was saved.  " + DateTime.Now.ToString();
            }
            catch (SerializationException er)
            {
                Console.WriteLine("Failed to serialize. Reason: " + er.Message);
                throw;
            }
            finally
            {
                fs.Close();
                edited = false;
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            edited = true;
            Point pt;

            int line, col, index;

            // get the current line
            index = this.textBox.SelectionStart;
            line = this.textBox.GetLineFromCharIndex(index);

            // get the caret position in pixel coordinates
            pt = this.textBox.GetPositionFromCharIndex(index);

            // now get the character index at the start of the line, and
            // subtract from the current index to get the column
            pt.X = 0;
            col = index - this.textBox.GetCharIndexFromPosition(pt);

            // finally, update the display in the status bar, incrementing the line and
            // column values so that the first line & first character position is
            // shown as "1, 1"
            this.statusLabel.Text = "Row: " + (++line).ToString() + ", Column: " + (++col).ToString();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(edited == true)
            {
                var res = MessageBox.Show("Do you want to save changes?", "Changes detected!", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if(res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PropForm propForm = new PropForm(textBox, textBox.Font);
            propForm.AddingNew += propForm_AddingNew;
            propForm.Show();
        }

        private void propForm_AddingNew(object sender, AddingNewEventArgs e)
        {
            textBox.ForeColor = e.passedTextBoxBase.ForeColor;
            textBox.BackColor = e.passedTextBoxBase.BackColor;
            textBox.Font = e.passedFont;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadFeatures(features);
        }

        private void loadFeatures(Shape theFeatures)
        {
            //this.textBox.ForeColor = theFeatures.textColor;
            //this.textBox.BackColor = theFeatures.textBackColor;
            //this.textBox.Font = theFeatures.textFont;
            this.Size = theFeatures.Size;
            this.Location = theFeatures.Location;
            this.Text = theFeatures.textTitle;
        }

        private void oathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oathDialog oath = new oathDialog();
            oath.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutDialog about = new aboutDialog();
            about.ShowDialog();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solidToolStripMenuItem.Checked = true;
            if (solidToolStripMenuItem.Checked)
            {
                compoundToolStripMenuItem.Checked = false;
                customToolStripMenuItem.Checked = false;
                features.PenType = PenType.Solid;
            }
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compoundToolStripMenuItem.Checked = true;
            if (compoundToolStripMenuItem.Checked)
            {
                solidToolStripMenuItem.Checked = false;
                customToolStripMenuItem.Checked = false;
                features.PenType = PenType.Compound;
            }
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customToolStripMenuItem.Checked = true;
            if (customToolStripMenuItem.Checked)
            {
                solidToolStripMenuItem.Checked = false;
                compoundToolStripMenuItem.Checked = false;
                features.PenType = PenType.CustomDashed;
            }
        }

        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solidBrushToolStripMenuItem.Checked = true;
            if (solidBrushToolStripMenuItem.Checked) 
            {
                hatchToolStripMenuItem.Checked = false;
                linearGradientToolStripMenuItem.Checked = false;
                features.BrushType = BrushType.Solid;
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hatchToolStripMenuItem.Checked = true;
            if (hatchToolStripMenuItem.Checked) 
            {
                solidBrushToolStripMenuItem.Checked = false;
                linearGradientToolStripMenuItem.Checked = false;
                features.BrushType = BrushType.Hatch;
            }
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linearGradientToolStripMenuItem.Checked = true;
            if (linearGradientToolStripMenuItem.Checked)
            {
                solidBrushToolStripMenuItem.Checked = false;
                hatchToolStripMenuItem.Checked = false;
                features.BrushType = BrushType.LinearGradient;
            }
        }
    }
}