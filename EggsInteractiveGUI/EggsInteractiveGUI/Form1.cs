using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int Chicken1;
            int Chicken2;
            int Chicken3;
            int Chicken4;
            int Chicken5;
            int sum;
            int dozen;
            int single;

            Chicken1 = Convert.ToInt32(txt1.Text);
            Chicken2 = Convert.ToInt32(txt2.Text);
            Chicken3 = Convert.ToInt32(txt3.Text);
            Chicken4 = Convert.ToInt32(txt4.Text);
            Chicken5 = Convert.ToInt32(txt5.Text);

            sum = Chicken1 + Chicken2 + Chicken3 + Chicken4 + Chicken5;
            dozen = sum / 12;
            single = sum % 12;

            lblSumBox.Text = "" + sum;
            lblDozenBox.Text = "" + dozen;
            lblSinglesBox.Text = "" + single;
        }
    }
}
