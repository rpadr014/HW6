using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using HW5ControlLibrary;

namespace HW5
{
    partial class ShapeDialog
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
            this.brushTypeLabel = new System.Windows.Forms.Label();
            this.brushTypeComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.shapePropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.xLabel2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.yLabel = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.penTypeLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.shapePropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // brushTypeLabel
            // 
            this.brushTypeLabel.AutoSize = true;
            this.brushTypeLabel.Location = new System.Drawing.Point(9, 52);
            this.brushTypeLabel.Name = "brushTypeLabel";
            this.brushTypeLabel.Size = new System.Drawing.Size(102, 25);
            this.brushTypeLabel.TabIndex = 3;
            this.brushTypeLabel.Text = "Brush Type:";
            // 
            // brushTypeComboBox
            // 
            this.brushTypeComboBox.FormattingEnabled = true;
            this.brushTypeComboBox.Items.AddRange(new object[] {
            "Linear Gradient",
            "Solid",
            "Hatched"});
            this.brushTypeComboBox.Location = new System.Drawing.Point(114, 44);
            this.brushTypeComboBox.Name = "brushTypeComboBox";
            this.brushTypeComboBox.Size = new System.Drawing.Size(206, 33);
            this.brushTypeComboBox.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(233, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 34);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // shapePropertiesGroupBox
            // 
            this.shapePropertiesGroupBox.Controls.Add(this.xLabel2);
            this.shapePropertiesGroupBox.Controls.Add(this.numericUpDown2);
            this.shapePropertiesGroupBox.Controls.Add(this.yLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.numericUpDown3);
            this.shapePropertiesGroupBox.Controls.Add(this.label4);
            this.shapePropertiesGroupBox.Controls.Add(this.heightLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.xLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.widthLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.numericUpDown1);
            this.shapePropertiesGroupBox.Controls.Add(this.sizeLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.penTypeLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.comboBox1);
            this.shapePropertiesGroupBox.Controls.Add(this.brushTypeLabel);
            this.shapePropertiesGroupBox.Controls.Add(this.brushTypeComboBox);
            this.shapePropertiesGroupBox.Location = new System.Drawing.Point(12, 12);
            this.shapePropertiesGroupBox.Name = "shapePropertiesGroupBox";
            this.shapePropertiesGroupBox.Size = new System.Drawing.Size(363, 266);
            this.shapePropertiesGroupBox.TabIndex = 6;
            this.shapePropertiesGroupBox.TabStop = false;
            this.shapePropertiesGroupBox.Text = "Shape Properties";
            this.shapePropertiesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // xLabel2
            // 
            this.xLabel2.AutoSize = true;
            this.xLabel2.Location = new System.Drawing.Point(221, 201);
            this.xLabel2.Name = "xLabel2";
            this.xLabel2.Size = new System.Drawing.Size(24, 25);
            this.xLabel2.TabIndex = 16;
            this.xLabel2.Text = "x:";
            this.xLabel2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(252, 195);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 31);
            this.numericUpDown2.TabIndex = 15;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(114, 201);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(25, 25);
            this.yLabel.TabIndex = 14;
            this.yLabel.Text = "y:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(145, 195);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(68, 31);
            this.numericUpDown3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Location:";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(221, 160);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(29, 25);
            this.heightLabel.TabIndex = 11;
            this.heightLabel.Text = "H:";
            this.heightLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // xLabel
            // 
            this.xLabel.Location = new System.Drawing.Point(252, 154);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(68, 31);
            this.xLabel.TabIndex = 10;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(114, 160);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(33, 25);
            this.widthLabel.TabIndex = 9;
            this.widthLabel.Text = "W:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 154);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 31);
            this.numericUpDown1.TabIndex = 8;
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Location = new System.Drawing.Point(61, 160);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(47, 25);
            this.sizeLabel.TabIndex = 7;
            this.sizeLabel.Text = "Size:";
            // 
            // penTypeLabel
            // 
            this.penTypeLabel.AutoSize = true;
            this.penTypeLabel.Location = new System.Drawing.Point(22, 108);
            this.penTypeLabel.Name = "penTypeLabel";
            this.penTypeLabel.Size = new System.Drawing.Size(86, 25);
            this.penTypeLabel.TabIndex = 5;
            this.penTypeLabel.Text = "Pen Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Linear Gradient",
            "Solid",
            "Hatched"});
            this.comboBox1.Location = new System.Drawing.Point(114, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // ShapeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 351);
            this.Controls.Add(this.shapePropertiesGroupBox);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShapeDialog";
            this.ShowIcon = false;
            this.Text = "Shape Dialog";
            this.shapePropertiesGroupBox.ResumeLayout(false);
            this.shapePropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label brushTypeLabel;
        private ComboBox brushTypeComboBox;
        private Button saveButton;
        private GroupBox shapePropertiesGroupBox;
        private Label penTypeLabel;
        private ComboBox comboBox1;
        private Label sizeLabel;
        private Label heightLabel;
        private NumericUpDown xLabel;
        private Label widthLabel;
        private NumericUpDown numericUpDown1;
        private Label xLabel2;
        private NumericUpDown numericUpDown2;
        private Label yLabel;
        private NumericUpDown numericUpDown3;
        private Label label4;
    }
}