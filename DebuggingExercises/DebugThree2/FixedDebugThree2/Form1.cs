using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree2
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Hello, " + txtName.Text + "!";
        }

        private void goodbyeButton_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Goodbye, " + txtName.Text + "!";
        }
    }
}
