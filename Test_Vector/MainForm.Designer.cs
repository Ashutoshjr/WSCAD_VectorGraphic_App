namespace Test_Vector
{
    partial class MainForm
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
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblColorValue = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeValue = new System.Windows.Forms.Label();
            this.lblCoordinates = new System.Windows.Forms.Label();
            this.lblCoordinateValue = new System.Windows.Forms.Label();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.lblFilledValue = new System.Windows.Forms.Label();
            this.lblFilled = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Location = new System.Drawing.Point(16, 486);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(92, 16);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Text = "errorMessage";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(50, 28);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(138, 23);
            this.lblColor.TabIndex = 7;
            this.lblColor.Text = "Color                :";
            // 
            // lblColorValue
            // 
            this.lblColorValue.AutoSize = true;
            this.lblColorValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorValue.Location = new System.Drawing.Point(217, 28);
            this.lblColorValue.Name = "lblColorValue";
            this.lblColorValue.Size = new System.Drawing.Size(52, 23);
            this.lblColorValue.TabIndex = 8;
            this.lblColorValue.Text = "color";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(49, 71);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(139, 23);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Type                 :";
            // 
            // lblTypeValue
            // 
            this.lblTypeValue.AutoSize = true;
            this.lblTypeValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeValue.Location = new System.Drawing.Point(223, 71);
            this.lblTypeValue.Name = "lblTypeValue";
            this.lblTypeValue.Size = new System.Drawing.Size(46, 23);
            this.lblTypeValue.TabIndex = 10;
            this.lblTypeValue.Text = "type";
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinates.Location = new System.Drawing.Point(49, 117);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(137, 23);
            this.lblCoordinates.TabIndex = 11;
            this.lblCoordinates.Text = "Coordinates     :";
            // 
            // lblCoordinateValue
            // 
            this.lblCoordinateValue.AutoSize = true;
            this.lblCoordinateValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordinateValue.Location = new System.Drawing.Point(217, 117);
            this.lblCoordinateValue.Name = "lblCoordinateValue";
            this.lblCoordinateValue.Size = new System.Drawing.Size(98, 23);
            this.lblCoordinateValue.TabIndex = 12;
            this.lblCoordinateValue.Text = "coordinate";
            // 
            // DetailPanel
            // 
            this.DetailPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DetailPanel.Controls.Add(this.lblFilledValue);
            this.DetailPanel.Controls.Add(this.lblFilled);
            this.DetailPanel.Controls.Add(this.lblColor);
            this.DetailPanel.Controls.Add(this.lblCoordinateValue);
            this.DetailPanel.Controls.Add(this.lblColorValue);
            this.DetailPanel.Controls.Add(this.lblCoordinates);
            this.DetailPanel.Controls.Add(this.lblType);
            this.DetailPanel.Controls.Add(this.lblTypeValue);
            this.DetailPanel.Location = new System.Drawing.Point(436, 132);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(499, 282);
            this.DetailPanel.TabIndex = 13;
            // 
            // lblFilledValue
            // 
            this.lblFilledValue.AutoSize = true;
            this.lblFilledValue.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilledValue.Location = new System.Drawing.Point(217, 168);
            this.lblFilledValue.Name = "lblFilledValue";
            this.lblFilledValue.Size = new System.Drawing.Size(52, 23);
            this.lblFilledValue.TabIndex = 14;
            this.lblFilledValue.Text = "filled";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilled.Location = new System.Drawing.Point(50, 168);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(134, 23);
            this.lblFilled.TabIndex = 13;
            this.lblFilled.Text = "Filled               :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(19, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 282);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select Shapes"});
            this.comboBox1.Location = new System.Drawing.Point(289, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 28);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Eras Demi ITC", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Shape Drawer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(947, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DetailPanel);
            this.Controls.Add(this.lblErrorMessage);
            this.Name = "MainForm";
            this.Text = "Vector Graphic";
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblColorValue;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeValue;
        private System.Windows.Forms.Label lblCoordinates;
        private System.Windows.Forms.Label lblCoordinateValue;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilledValue;
        private System.Windows.Forms.Label lblFilled;
    }
}

