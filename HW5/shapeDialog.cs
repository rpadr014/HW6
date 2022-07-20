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
        public ShapeDialog()
        {
            InitializeComponent();
        }

        public event EventHandler SaveButtonClicked;
        public Shape Shape;

        protected virtual void OnSaveButtonClicked(EventArgs e)
        {
            SaveButtonClicked.Invoke(this, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

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
