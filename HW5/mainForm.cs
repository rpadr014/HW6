using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace HW5
{
    public partial class mainForm : Form
    {
        private ArrayList file = new ArrayList();
        private string fileName = "";
        private bool edited = false;
        public Features features = new Features();

        public mainForm()
        {
            InitializeComponent();
        }

        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            file.Clear();
            fileName = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.Clear();
            if (fileName == "")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                string[] allLines = textBox.Text.Split('\n');
                foreach (string text in allLines)
                {
                    file.Add(text);
                }
                
                serializer();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "soap files|*.soap";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                //string extension = Path.GetExtension(fileName);
                string[] allLines = textBox.Text.Split('\n');
                foreach (string text in allLines)
                {
                    file.Add(text);
                }
                serializer();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            file.Clear();

            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                try
                {
                    SoapFormatter formatter = new SoapFormatter();
                    file = (ArrayList)formatter.Deserialize(fs);
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

                this.textBox.Clear();
                foreach (string s in file)
                {
                    textBox.Text += s + Environment.NewLine;
                }
            }
        }

        private void serializer()
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            SoapFormatter formatter = new SoapFormatter();

            try
            {
                formatter.Serialize(fs, file);
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

        private void loadFeatures(Features theFeatures)
        {
            this.textBox.ForeColor = theFeatures.textColor;
            this.textBox.BackColor = theFeatures.textBackColor;
            this.textBox.Font = theFeatures.textFont;
            this.Size = theFeatures.Size;
            this.Location = theFeatures.Location;
            this.Text = theFeatures.textTitle;
        }




    }
}