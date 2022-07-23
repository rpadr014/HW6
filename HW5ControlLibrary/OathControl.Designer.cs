using HW5ControlLibrary;
using HW6ControlLibrary;

namespace HW5ControlLibrary
{
    partial class OathControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gradient = new HW6ControlLibrary.PathGradient();
            this.oathLabel = new System.Windows.Forms.Label();
            this.gradient.SuspendLayout();
            this.SuspendLayout();
            //
            // pathGradient
            //
            this.gradient.angle = 0F;
            this.gradient.colorTwo = System.Drawing.Color.Gray;
            this.gradient.Controls.Add(this.oathLabel);
            this.gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "pathGradient";
            this.gradient.Size = new System.Drawing.Size(1197, 282);
            this.gradient.TabIndex = 0;
            this.gradient.colorOne = System.Drawing.Color.Black;
            // 
            // oathLabel
            // 
            this.oathLabel.BackColor = System.Drawing.Color.Transparent;
            this.oathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.oathLabel.ForeColor = System.Drawing.Color.Teal;
            this.oathLabel.Location = new System.Drawing.Point(0, 0);
            this.oathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.oathLabel.Name = "oathLabel";
            this.oathLabel.Size = new System.Drawing.Size(1197, 282);
            this.oathLabel.TabIndex = 0;
            this.oathLabel.Text = " I understand that this is a group project.\r\n\r\nIt is in my best interest to parti" +
    "cipate in writing the homework and study all the\r\ncode from the homework.";
            this.oathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.oathLabel.Click += new System.EventHandler(this.oathLabel_Click);
            // 
            // OathControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gradient);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OathControl";
            this.Size = new System.Drawing.Size(1197, 282);
            this.gradient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private PathGradient gradient;
        private System.Windows.Forms.Label oathLabel;
    }
}


