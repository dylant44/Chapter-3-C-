namespace FixedDebugThree2
{
    partial class GreetingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.btnHello = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnGoodbye = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(42, 117);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(75, 23);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.helloButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose a button to see a Hello greeting\r\nor a Goodbye greeting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your name: ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(148, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(93, 20);
            this.txtName.TabIndex = 4;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(66, 178);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(140, 27);
            this.lblOutput.TabIndex = 5;
            // 
            // btnGoodbye
            // 
            this.btnGoodbye.Location = new System.Drawing.Point(148, 117);
            this.btnGoodbye.Name = "btnGoodbye";
            this.btnGoodbye.Size = new System.Drawing.Size(75, 23);
            this.btnGoodbye.TabIndex = 6;
            this.btnGoodbye.Text = "Goodbye";
            this.btnGoodbye.UseVisualStyleBackColor = true;
            this.btnGoodbye.Click += new System.EventHandler(this.button1_Click);
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 249);
            this.Controls.Add(this.btnGoodbye);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHello);
            this.Name = "GreetingForm";
            this.Text = "Two Greetings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnGoodbye;
    }
}

