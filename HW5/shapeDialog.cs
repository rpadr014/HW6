using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5
{
    public partial class ShapeDialog : Form
    {
        private Shape shape;

        public ShapeDialog(Shape shape)
        {
            InitializeComponent();
            this.shape = shape;
            this.brushTypeComboBox.DataSource = Enum.GetValues(typeof(BrushType));
            this.penTypeComboBox.DataSource = Enum.GetValues(typeof(PenType));
            this.brushTypeComboBox.SelectedItem = this.shape.BrushType;
            this.penTypeComboBox.SelectedItem = this.shape.PenType;
            this.widthBox.Value = this.shape.ShapeSize.Width;
            this.heightBox.Value = this.shape.ShapeSize.Height;
            this.yBox.Value = this.shape.ShapeLocation.Y;
            this.xBox.Value = this.shape.ShapeLocation.X;
        }

        public event EventHandler SaveButtonClicked;
        public Shape Shape;



        private void OnSaveButtonClicked(object sender, EventArgs e)
        {
            this.shape.BrushType = (BrushType) Enum.Parse(typeof(BrushType), this.brushTypeComboBox.SelectedItem.ToString());
            this.shape.PenType = (PenType) Enum.Parse(typeof(PenType), this.penTypeComboBox.SelectedItem.ToString());
            this.shape.ShapeSize = new Size((int)this.widthBox.Value, (int)this.heightBox.Value);
            this.shape.ShapeLocation = new Point((int)this.xBox.Value, ((int)this.yBox.Value));
            if(SaveButtonClicked != null)
            {
                SaveButtonClicked(this, EventArgs.Empty);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
