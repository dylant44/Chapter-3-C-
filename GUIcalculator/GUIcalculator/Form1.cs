using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            sum = num1 + num2;
            lblAdd.Text = "The sum is " + sum;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int diff;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            diff = num1 - num2;
            lblSubtract.Text = "The difference is " + diff;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            product = num1 * num2;
            lblMultiply.Text = "The product is " + product;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int quotient;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            quotient = num1 / num2;
            lblDivide.Text = "The quotient is " + quotient;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            mod = num1 % num2;
            lblMod.Text = "The modulus is " + mod;
        }

        private void lblMod_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int num1;
            int num2;
           
            int sum;
            int diff;
            int product;
            int quotient;
            int mod;
// add
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            sum = num1 + num2;
            lblAdd.Text = "The sum is " + sum;
 //multiply
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            product = num1 * num2;
            lblMultiply.Text = "The product is " + product;
 //divide
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            quotient = num1 / num2;
            lblDivide.Text = "The quotient is " + quotient;
 //modulus
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            mod = num1 % num2;
            lblMod.Text = "The modulus is " + mod;
 //subtract
            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            diff = num1 - num2;
            lblSubtract.Text = "The difference is " + diff;
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
