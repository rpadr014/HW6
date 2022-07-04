using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using HW5ControlLibrary;

namespace HW5
{
    partial class oathDialog
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.oathControl1 = new HW5ControlLibrary.OathControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.oathControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 201);
            this.panel1.TabIndex = 3;
            // 
            // oathControl1
            // 
            this.oathControl1.BackColor = System.Drawing.Color.Transparent;
            this.oathControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oathControl1.Location = new System.Drawing.Point(0, 0);
            this.oathControl1.Name = "oathControl1";
            this.oathControl1.Size = new System.Drawing.Size(803, 201);
            this.oathControl1.TabIndex = 0;
            // 
            // oathDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::HW5.Properties.Resources.headphones;
            this.ClientSize = new System.Drawing.Size(803, 432);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "oathDialog";
            this.ShowIcon = false;
            this.Text = "OathDialog";
            this.Load += new System.EventHandler(this.oathDialog_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private OathControl oathControl1;
    }
}