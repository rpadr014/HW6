using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using HW6;
using System.Drawing.Drawing2D;

namespace HW5
{
    public partial class mainForm : Form
    {
        private string fileName = "";
        private bool edited = false;
        public Shape shape = new Shape();
        private Point startPos, currentPos;
        private Boolean paint;
        private Document doc = new Document();
        private Pen canvasPen = new Pen(Color.Black);
        private Color brushColor = Color.Black;
        private Color penColor = Color.Black;

        public mainForm()
        {
            InitializeComponent();
        }

        private Rectangle getRectangle()
        {
            return new Rectangle(
                Math.Min(startPos.X, currentPos.X),
                Math.Min(startPos.Y, currentPos.Y),
                Math.Abs(startPos.X - currentPos.X),
                Math.Abs(startPos.Y - currentPos.Y));
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
                    Shape newShapes = new Shape();
                    shape = newShapes;
                    statusLabel.Text = "New document created.";
                    this.Text = "New Document";
                    doc.savedShapes.Clear();
                    this.pictureBox.Refresh();
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

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                FileStream fs = new FileStream(fileName, FileMode.Open);
                try
                {
                    SoapFormatter formatter = new SoapFormatter();
                    Document newfeatures = (Document)formatter.Deserialize(fs);
                    doc = newfeatures;
                    loadFeatures(doc);
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
                //shape.ShapeSize = new Size(this.Size.Width, this.Size.Height);
                //shape.ShapeLocation = new Point(this.Location.X, this.Location.Y);
                shape.textTitle = fileName;
                formatter.Serialize(fs, doc);
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

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited == true)
            {
                var res = MessageBox.Show("Do you want to save changes?", "Changes detected!", MessageBoxButtons.YesNoCancel);

                if (res == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(sender, e);
                }
                else if (res == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            loadFeatures(doc);
        }

        private void loadFeatures(Document theFeatures)
        {
            foreach(Shape s in theFeatures.savedShapes)
            {
                s.Pen = new Pen(s.PenColor, 1);
            }
            this.pictureBox.Refresh();
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
            compoundToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
            linearGradientToolStripMenuItem.Checked = false;

            if (solidToolStripMenuItem.Checked)
            {
                compoundToolStripMenuItem.Checked = false;
                customToolStripMenuItem.Checked = false;
                canvasPen = new Pen(penColor);
                canvasPen.DashStyle = DashStyle.Solid;
            }
        }

        private void compoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compoundToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
            linearGradientToolStripMenuItem.Checked = false;

            if (compoundToolStripMenuItem.Checked)
            {
                solidToolStripMenuItem.Checked = false;
                customToolStripMenuItem.Checked = false;
                canvasPen = new Pen(penColor);
                canvasPen.CompoundArray = new float[] { 0.0f, 0.2f, 0.3f, 0.4f, 0.5f, 1.0f };
            }
        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
            linearGradientToolStripMenuItem.Checked = false;

            if (customToolStripMenuItem.Checked)
            {
                solidToolStripMenuItem.Checked = false;
                compoundToolStripMenuItem.Checked = false;
                canvasPen = new Pen(penColor);
                canvasPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
            }
        }

        private void solidBrushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            solidBrushToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;
            linearGradientToolStripMenuItem.Checked = false;

            if (solidBrushToolStripMenuItem.Checked)
            {
                hatchToolStripMenuItem.Checked = false;
                linearGradientToolStripMenuItem.Checked = false;
                canvasPen = new Pen(new SolidBrush(brushColor), 10);
            }
        }

        private void hatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hatchToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            solidBrushToolStripMenuItem.Checked = false;
            linearGradientToolStripMenuItem.Checked = false;

            if (hatchToolStripMenuItem.Checked)
            {
                solidBrushToolStripMenuItem.Checked = false;
                linearGradientToolStripMenuItem.Checked = false;
                canvasPen = new Pen(new HatchBrush(HatchStyle.Plaid,brushColor), 10);
            }
        }

        private void linearGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            linearGradientToolStripMenuItem.Checked = true;
            solidToolStripMenuItem.Checked = false;
            compoundToolStripMenuItem.Checked = false;
            customToolStripMenuItem.Checked = false;
            solidBrushToolStripMenuItem.Checked = false;
            hatchToolStripMenuItem.Checked = false;

            if (linearGradientToolStripMenuItem.Checked)
            {
                solidBrushToolStripMenuItem.Checked = false;
                hatchToolStripMenuItem.Checked = false;
                canvasPen = new Pen(new LinearGradientBrush(new PointF(0,0),new PointF(0,5), brushColor, penColor), 10);
            }
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape.ShapeType = ShapeType.Rectangle;
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            edited = true;
            for (int i = 0; i < doc.savedShapes.Count; i++)
            {
                if (doc.savedShapes[i].ShapeType == ShapeType.Rectangle)
                {
                    if (doc.savedShapes[i].Pen == null)
                    {
                        e.Graphics.DrawRectangle(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y, 
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                }
                else if (doc.savedShapes[i].ShapeType == ShapeType.Ellipse)
                {
                    if (doc.savedShapes[i].Pen == null)
                    {
                        e.Graphics.DrawEllipse(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                    else 
                    {
                        e.Graphics.DrawEllipse(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                        
                }
                else if (doc.savedShapes[i].ShapeType == ShapeType.Custom)
                {
                    if (doc.savedShapes[i].Pen == null)
                    {
                        e.Graphics.DrawRectangle(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                        e.Graphics.DrawEllipse(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                        e.Graphics.DrawEllipse(canvasPen, new Rectangle(doc.savedShapes[i].ShapeLocation.X, doc.savedShapes[i].ShapeLocation.Y,
                            doc.savedShapes[i].ShapeSize.Width, doc.savedShapes[i].ShapeSize.Height));
                    }
                }

            }

            if (paint)
            {
                if (shape.ShapeType == ShapeType.Rectangle)
                {
                    e.Graphics.DrawRectangle(canvasPen, getRectangle());
                }
                if (shape.ShapeType == ShapeType.Ellipse)
                {
                    e.Graphics.DrawEllipse(canvasPen, getRectangle());
                }
                if (shape.ShapeType == ShapeType.Custom)
                {
                    e.Graphics.DrawRectangle(canvasPen, getRectangle());
                    e.Graphics.DrawEllipse(canvasPen, getRectangle());
                }
            }
        }

        private Shape selectedShape;

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentPos = startPos = e.Location;
                paint = true;
            }
            else if (e.Button == MouseButtons.Right)
            {

                foreach(Shape s in doc.savedShapes)
                {
                    Rectangle rectangle = new Rectangle(s.ShapeLocation.X, s.ShapeLocation.Y, s.ShapeSize.Width, s.ShapeSize.Height);
                    if (rectangle.Contains(e.Location))
                    {
                        this.pictureBox.Invalidate();
                        
                        this.selectedShape = s;

                        if (s.ShapeType == ShapeType.Rectangle) Graphics.FromImage(this.pictureBox.Image).FillRectangle(new SolidBrush(Color.FromArgb(128, 0, 0, 255)), rectangle);
                        if (s.ShapeType == ShapeType.Ellipse) Graphics.FromImage(this.pictureBox.Image).FillEllipse(new SolidBrush(Color.FromArgb(128, 0, 0, 255)), rectangle);
                        this.pictureBox.Refresh();
                        ShapeDialog shapeDialog = new ShapeDialog(s);
                        shapeDialog.SaveButtonClicked += ShapeDialog_SaveButtonClicked;
                        shapeDialog.FormClosing += ShapeDialog_FormClosing;
                        shapeDialog.ShowDialog();

                        break;
                    }
                }

            }
        }

        private void ShapeDialog_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if(selectedShape != null)
            {
                Rectangle rectangle = new Rectangle(selectedShape.ShapeLocation.X, selectedShape.ShapeLocation.Y, selectedShape.ShapeSize.Width, selectedShape.ShapeSize.Height);
                if (selectedShape.ShapeType == ShapeType.Rectangle) Graphics.FromImage(this.pictureBox.Image).FillRectangle(new SolidBrush(Color.White), rectangle);
                if (selectedShape.ShapeType == ShapeType.Ellipse) Graphics.FromImage(this.pictureBox.Image).FillEllipse(new SolidBrush(Color.White), rectangle);

                this.pictureBox.Refresh();
            }
            
        }

        private void ShapeDialog_SaveButtonClicked(object? sender, EventArgs e)
        {
            this.pictureBox.Refresh();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            currentPos = e.Location;
            if (paint)
            {
                this.pictureBox.Invalidate();
            }
        }

        private void penColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog penCol = new ColorDialog();
            if(penCol.ShowDialog() == DialogResult.OK)
            {
               penColor = penCol.Color;
            }
        }

        private void brushColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog brushCol = new ColorDialog();
            if(brushCol.ShowDialog() == DialogResult.OK)
            {
                brushColor = brushCol.Color;
            }
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ellipseToolStripMenuItem.Checked = true;
            if (ellipseToolStripMenuItem.Checked)
            {
                rectangleToolStripMenuItem.Checked = false;
                customToolStripMenuItem.Checked = false;
                shape.ShapeType = ShapeType.Ellipse;
            }
        }

        private void customToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customToolStripMenuItem.Checked = true;
            if (customToolStripMenuItem.Checked)
            {
                rectangleToolStripMenuItem.Checked = false;
                ellipseToolStripMenuItem.Checked = false;
                shape.ShapeType = ShapeType.Custom;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Shape tempS = new Shape();
            if (paint)
            {
                Rectangle r = getRectangle();
                tempS.ShapeLocation = r.Location;
                tempS.ShapeSize = r.Size;
                tempS.ShapeType = shape.ShapeType;
                tempS.PenColor = shape.Pen.Color;
                tempS.Pen = shape.Pen;
                doc.savedShapes.Add(tempS);

                this.pictureBox.Invalidate();
            }
            paint = false;
        }
    }
}