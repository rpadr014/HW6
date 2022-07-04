namespace HW5ControlLibrary
{
    partial class BaseDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameControl = new HW5ControlLibrary.NameControl();
            this.courseControl = new HW5ControlLibrary.CourseControl();
            this.midPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // nameControl
            // 
            this.nameControl.BackColor = System.Drawing.Color.Azure;
            this.nameControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.nameControl.ForeColor = System.Drawing.Color.Black;
            this.nameControl.Location = new System.Drawing.Point(0, 276);
            this.nameControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameControl.Name = "nameControl";
            this.nameControl.Size = new System.Drawing.Size(800, 174);
            this.nameControl.TabIndex = 0;
            // 
            // courseControl
            // 
            this.courseControl.BackColor = System.Drawing.Color.Transparent;
            this.courseControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.courseControl.Location = new System.Drawing.Point(0, 0);
            this.courseControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.courseControl.Name = "courseControl";
            this.courseControl.Size = new System.Drawing.Size(800, 57);
            this.courseControl.TabIndex = 1;
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.Transparent;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 57);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(800, 219);
            this.midPanel.TabIndex = 2;
            // 
            // BaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.courseControl);
            this.Controls.Add(this.nameControl);
            this.Name = "BaseDialog";
            this.Text = "Base Dialog";
            this.Load += new System.EventHandler(this.BaseDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private NameControl nameControl;
        private CourseControl courseControl;
        private System.Windows.Forms.Panel midPanel;
    }
}