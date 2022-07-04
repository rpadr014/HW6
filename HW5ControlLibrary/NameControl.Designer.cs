namespace HW5ControlLibrary
{
    partial class NameControl
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
            this.memberNames = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberNames
            // 
            this.memberNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memberNames.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberNames.ForeColor = System.Drawing.Color.DodgerBlue;
            this.memberNames.Location = new System.Drawing.Point(0, 0);
            this.memberNames.Name = "memberNames";
            this.memberNames.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.memberNames.Size = new System.Drawing.Size(337, 174);
            this.memberNames.TabIndex = 0;
            this.memberNames.Text = "Thang Nguyen\r\nRicardo Padron\r\nLaura Penza\r\nNoel Pereda\r\nPedro Prieto\r\nDany Quinta" +
    "na";
            this.memberNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupName
            // 
            this.groupName.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupName.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupName.ForeColor = System.Drawing.Color.Teal;
            this.groupName.Location = new System.Drawing.Point(0, 0);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(337, 38);
            this.groupName.TabIndex = 1;
            this.groupName.Text = "Parallel Inertia";
            this.groupName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.groupName);
            this.Controls.Add(this.memberNames);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "NameControl";
            this.Size = new System.Drawing.Size(337, 174);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label memberNames;
        private System.Windows.Forms.Label groupName;
    }
}
