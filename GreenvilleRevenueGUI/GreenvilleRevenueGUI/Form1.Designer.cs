namespace GreenvilleRevenueGUI
{
    partial class Form1
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
            this.lblLastYearTitle = new System.Windows.Forms.Label();
            this.lblThisYearTitle = new System.Windows.Forms.Label();
            this.lblExpectedTitle = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblBigOrSmallTitle = new System.Windows.Forms.Label();
            this.lblBigOrSmallBox = new System.Windows.Forms.Label();
            this.lblExpectedBox = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLastYearTitle
            // 
            this.lblLastYearTitle.Location = new System.Drawing.Point(136, 32);
            this.lblLastYearTitle.Name = "lblLastYearTitle";
            this.lblLastYearTitle.Size = new System.Drawing.Size(93, 46);
            this.lblLastYearTitle.TabIndex = 0;
            this.lblLastYearTitle.Text = "Enter Number of Contestants From Previous Year";
            // 
            // lblThisYearTitle
            // 
            this.lblThisYearTitle.Location = new System.Drawing.Point(136, 95);
            this.lblThisYearTitle.Name = "lblThisYearTitle";
            this.lblThisYearTitle.Size = new System.Drawing.Size(81, 51);
            this.lblThisYearTitle.TabIndex = 1;
            this.lblThisYearTitle.Text = "Number of Contestants This Year";
            // 
            // lblExpectedTitle
            // 
            this.lblExpectedTitle.AutoSize = true;
            this.lblExpectedTitle.Location = new System.Drawing.Point(136, 217);
            this.lblExpectedTitle.Name = "lblExpectedTitle";
            this.lblExpectedTitle.Size = new System.Drawing.Size(99, 13);
            this.lblExpectedTitle.TabIndex = 2;
            this.lblExpectedTitle.Text = "Expected Revenue";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(314, 32);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(314, 95);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 7;
            // 
            // lblBigOrSmallTitle
            // 
            this.lblBigOrSmallTitle.Location = new System.Drawing.Point(136, 258);
            this.lblBigOrSmallTitle.Name = "lblBigOrSmallTitle";
            this.lblBigOrSmallTitle.Size = new System.Drawing.Size(104, 29);
            this.lblBigOrSmallTitle.TabIndex = 8;
            this.lblBigOrSmallTitle.Text = "More or Less Than Last Year?";
            // 
            // lblBigOrSmallBox
            // 
            this.lblBigOrSmallBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBigOrSmallBox.Location = new System.Drawing.Point(311, 258);
            this.lblBigOrSmallBox.Name = "lblBigOrSmallBox";
            this.lblBigOrSmallBox.Size = new System.Drawing.Size(80, 17);
            this.lblBigOrSmallBox.TabIndex = 9;
            // 
            // lblExpectedBox
            // 
            this.lblExpectedBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExpectedBox.Location = new System.Drawing.Point(311, 217);
            this.lblExpectedBox.Name = "lblExpectedBox";
            this.lblExpectedBox.Size = new System.Drawing.Size(80, 17);
            this.lblExpectedBox.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(139, 173);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblExpectedBox);
            this.Controls.Add(this.lblBigOrSmallBox);
            this.Controls.Add(this.lblBigOrSmallTitle);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblExpectedTitle);
            this.Controls.Add(this.lblThisYearTitle);
            this.Controls.Add(this.lblLastYearTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLastYearTitle;
        private System.Windows.Forms.Label lblThisYearTitle;
        private System.Windows.Forms.Label lblExpectedTitle;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblBigOrSmallTitle;
        private System.Windows.Forms.Label lblBigOrSmallBox;
        private System.Windows.Forms.Label lblExpectedBox;
        private System.Windows.Forms.Button btnCalculate;
    }
}

