using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW5ControlLibrary
{
    public partial class BaseForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public BaseForm()
        {
            InitializeComponent();
        }

        private void baseForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void baseForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void baseForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void colorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog.Color;
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
                this.BackColor = colorDialog.Color;
        }

        private void closeChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
