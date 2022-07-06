namespace HW5
{
    partial class PropForm
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.backgroundButton = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.propTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fontButton
            // 
            this.fontButton.Location = new System.Drawing.Point(11, 64);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(75, 23);
            this.fontButton.TabIndex = 1;
            this.fontButton.Text = "Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(92, 64);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 2;
            this.colorButton.Text = "Font Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundButton
            // 
            this.backgroundButton.Location = new System.Drawing.Point(173, 63);
            this.backgroundButton.Name = "backgroundButton";
            this.backgroundButton.Size = new System.Drawing.Size(75, 23);
            this.backgroundButton.TabIndex = 3;
            this.backgroundButton.Text = "Back Color";
            this.backgroundButton.UseVisualStyleBackColor = true;
            this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
            // 
            // propTextBox
            // 
            this.propTextBox.Location = new System.Drawing.Point(13, 23);
            this.propTextBox.Name = "propTextBox";
            this.propTextBox.ReadOnly = true;
            this.propTextBox.Size = new System.Drawing.Size(236, 23);
            this.propTextBox.TabIndex = 4;
            this.propTextBox.Text = "Font";
            this.propTextBox.BackColorChanged += new System.EventHandler(this.propTextBox_BackColorChanged);
            this.propTextBox.ForeColorChanged += new System.EventHandler(this.propTextBox_ForeColorChanged);
            // 
            // PropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 95);
            this.Controls.Add(this.propTextBox);
            this.Controls.Add(this.backgroundButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.fontButton);
            this.Name = "PropForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PropForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PropForm_FormClosed);
            this.Load += new System.EventHandler(this.PropForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private Button fontButton;
        private Button colorButton;
        private Button backgroundButton;
        private ColorDialog colorDialog2;
        private TextBox propTextBox;
    }
}