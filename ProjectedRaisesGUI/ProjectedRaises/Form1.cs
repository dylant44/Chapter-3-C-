using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double currentSalary;
            double raise;
            double total;

            currentSalary = Convert.ToInt32(txt1.Text);

            raise = currentSalary * .04;
            total = currentSalary + raise;

            lblCurrentBox.Text = "" + currentSalary.ToString("C");
            lblRaiseBox.Text = "" + raise.ToString("C");
            lblTotalBox.Text = "" + total.ToString("C");
        }
    }
}
