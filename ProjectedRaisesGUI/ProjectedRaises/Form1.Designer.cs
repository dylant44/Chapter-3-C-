namespace ProjectedRaises
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCurrentBox = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.lblRaise = new System.Windows.Forms.Label();
            this.lblRaiseBox = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(343, 73);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(106, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCurrentBox
            // 
            this.lblCurrentBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrentBox.Location = new System.Drawing.Point(343, 152);
            this.lblCurrentBox.Name = "lblCurrentBox";
            this.lblCurrentBox.Size = new System.Drawing.Size(100, 23);
            this.lblCurrentBox.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(103, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(138, 13);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Calculate Next Years Salary";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(103, 80);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(101, 13);
            this.lblEnter.TabIndex = 4;
            this.lblEnter.Text = "Enter Current Salary";
            // 
            // lblCurrent
            // 
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.Location = new System.Drawing.Point(264, 157);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(73, 13);
            this.lblCurrent.TabIndex = 5;
            this.lblCurrent.Text = "Current Salary";
            // 
            // lblRaise
            // 
            this.lblRaise.AutoSize = true;
            this.lblRaise.Location = new System.Drawing.Point(264, 204);
            this.lblRaise.Name = "lblRaise";
            this.lblRaise.Size = new System.Drawing.Size(34, 13);
            this.lblRaise.TabIndex = 6;
            this.lblRaise.Text = "Raise";
            // 
            // lblRaiseBox
            // 
            this.lblRaiseBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaiseBox.Location = new System.Drawing.Point(343, 194);
            this.lblRaiseBox.Name = "lblRaiseBox";
            this.lblRaiseBox.Size = new System.Drawing.Size(100, 23);
            this.lblRaiseBox.TabIndex = 7;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(264, 243);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalBox
            // 
            this.lblTotalBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBox.Location = new System.Drawing.Point(343, 233);
            this.lblTotalBox.Name = "lblTotalBox";
            this.lblTotalBox.Size = new System.Drawing.Size(100, 23);
            this.lblTotalBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalBox);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRaiseBox);
            this.Controls.Add(this.lblRaise);
            this.Controls.Add(this.lblCurrent);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCurrentBox);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCurrentBox;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Label lblRaise;
        private System.Windows.Forms.Label lblRaiseBox;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalBox;
    }
}

