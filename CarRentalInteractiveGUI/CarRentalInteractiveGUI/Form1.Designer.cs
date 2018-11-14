namespace CarRentalInteractiveGUI
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
            this.lblDaysInput = new System.Windows.Forms.Label();
            this.lblMilesInput = new System.Windows.Forms.Label();
            this.lblDaysCostBox = new System.Windows.Forms.Label();
            this.lblMilesCostBox = new System.Windows.Forms.Label();
            this.lblTotalCostBox = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblDaysCost = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblMilesCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysInput
            // 
            this.lblDaysInput.AutoSize = true;
            this.lblDaysInput.Location = new System.Drawing.Point(160, 33);
            this.lblDaysInput.Name = "lblDaysInput";
            this.lblDaysInput.Size = new System.Drawing.Size(167, 13);
            this.lblDaysInput.TabIndex = 0;
            this.lblDaysInput.Text = "Enter the Number of Days Rented";
            // 
            // lblMilesInput
            // 
            this.lblMilesInput.AutoSize = true;
            this.lblMilesInput.Location = new System.Drawing.Point(160, 66);
            this.lblMilesInput.Name = "lblMilesInput";
            this.lblMilesInput.Size = new System.Drawing.Size(163, 13);
            this.lblMilesInput.TabIndex = 1;
            this.lblMilesInput.Text = "Enter the Number of Miles Driven";
            // 
            // lblDaysCostBox
            // 
            this.lblDaysCostBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDaysCostBox.Location = new System.Drawing.Point(365, 116);
            this.lblDaysCostBox.Name = "lblDaysCostBox";
            this.lblDaysCostBox.Size = new System.Drawing.Size(100, 23);
            this.lblDaysCostBox.TabIndex = 2;
            // 
            // lblMilesCostBox
            // 
            this.lblMilesCostBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMilesCostBox.Location = new System.Drawing.Point(365, 150);
            this.lblMilesCostBox.Name = "lblMilesCostBox";
            this.lblMilesCostBox.Size = new System.Drawing.Size(100, 21);
            this.lblMilesCostBox.TabIndex = 3;
            // 
            // lblTotalCostBox
            // 
            this.lblTotalCostBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCostBox.Location = new System.Drawing.Point(365, 183);
            this.lblTotalCostBox.Name = "lblTotalCostBox";
            this.lblTotalCostBox.Size = new System.Drawing.Size(100, 22);
            this.lblTotalCostBox.TabIndex = 4;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(365, 26);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(365, 59);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(163, 116);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDaysCost
            // 
            this.lblDaysCost.AutoSize = true;
            this.lblDaysCost.Location = new System.Drawing.Point(304, 126);
            this.lblDaysCost.Name = "lblDaysCost";
            this.lblDaysCost.Size = new System.Drawing.Size(55, 13);
            this.lblDaysCost.TabIndex = 8;
            this.lblDaysCost.Text = "Days Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(304, 184);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(31, 13);
            this.lblTotalCost.TabIndex = 9;
            this.lblTotalCost.Text = "Total";
            // 
            // lblMilesCost
            // 
            this.lblMilesCost.AutoSize = true;
            this.lblMilesCost.Location = new System.Drawing.Point(304, 158);
            this.lblMilesCost.Name = "lblMilesCost";
            this.lblMilesCost.Size = new System.Drawing.Size(55, 13);
            this.lblMilesCost.TabIndex = 10;
            this.lblMilesCost.Text = "Miles Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMilesCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblDaysCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblTotalCostBox);
            this.Controls.Add(this.lblMilesCostBox);
            this.Controls.Add(this.lblDaysCostBox);
            this.Controls.Add(this.lblMilesInput);
            this.Controls.Add(this.lblDaysInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDaysInput;
        private System.Windows.Forms.Label lblMilesInput;
        private System.Windows.Forms.Label lblDaysCostBox;
        private System.Windows.Forms.Label lblMilesCostBox;
        private System.Windows.Forms.Label lblTotalCostBox;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDaysCost;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblMilesCost;
    }
}

