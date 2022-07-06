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
    public partial class PropForm : Form
    {
        public event EventHandler<AddingNewEventArgs> AddingNew;
        public bool goodColor = true;

        public PropForm(TextBox textBox, Font font)
        {
            InitializeComponent();
            propTextBox.BackColor = textBox.BackColor; 
            propTextBox.ForeColor = textBox.ForeColor;
            propTextBox.Font = font;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1 = new FontDialog();
            fontDialog1.ShowDialog();
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                propTextBox.Font = fontDialog1.Font;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                propTextBox.ForeColor = colorDialog1.Color;
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            colorDialog2 = new ColorDialog();
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                propTextBox.BackColor = colorDialog2.Color;
            }
        }

        private void PropForm_Load(object sender, EventArgs e)
        {
        }

        private void PropForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void propTextBox_ForeColorChanged(object sender, EventArgs e)
        {
            Color c1 = propTextBox.ForeColor;
            Color c2 = propTextBox.BackColor;

            if (!calculateContrast(c1, c2))
            {
                MessageBox.Show("Change Color.");
                goodColor = false;
            } else
            {
                goodColor = true;
            }
        }

        private bool calculateContrast(Color c1, Color c2)
        {
            bool passed = false;

            double l1 = (0.2126 * c1.R + 0.715 * c1.G + 0.0722 * c1.B);
            double l2 = (0.2126 * c2.R + 0.715 * c2.G + 0.0722 * c2.B);

            if (c1.GetBrightness() > c2.GetBrightness())
            {
                if ((l1 + 0.05) / (l2 + 0.05) > 4.5) {
                    passed = true;
                }
            } else
            {
                if ((l2 + 0.05) / (l1 + 0.05) > 4.5)
                {
                    passed = true;
                }
            }

            return passed;
        }

        

        private void PropForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (goodColor)
            {
                var handler = AddingNew;
                AddingNew.Invoke(this, new AddingNewEventArgs(propTextBox, propTextBox.Font));
            } else
            {
                e.Cancel = true;
            }
        }

        private void propTextBox_BackColorChanged(object sender, EventArgs e)
        {
            Color c1 = propTextBox.ForeColor;
            Color c2 = propTextBox.BackColor;

            if (!calculateContrast(c1, c2))
            {
                MessageBox.Show("Change Color.");
                goodColor = false;
            }
            else
            {
                goodColor = true;
            }
        }
    }
}
