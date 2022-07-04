namespace HW5ControlLibrary
{
    partial class CourseControl
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
            this.course = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // course
            // 
            this.course.Dock = System.Windows.Forms.DockStyle.Top;
            this.course.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.Teal;
            this.course.Location = new System.Drawing.Point(0, 0);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(570, 27);
            this.course.TabIndex = 0;
            this.course.Text = "COP4226 - Advanced Windows Programming";
            this.course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // semester
            // 
            this.semester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.semester.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.ForeColor = System.Drawing.Color.DodgerBlue;
            this.semester.Location = new System.Drawing.Point(0, 27);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(570, 30);
            this.semester.TabIndex = 1;
            this.semester.Text = "Summer 2022";
            this.semester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.semester);
            this.Controls.Add(this.course);
            this.Name = "CourseControl";
            this.Size = new System.Drawing.Size(570, 57);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label course;
        private System.Windows.Forms.Label semester;
    }
}
