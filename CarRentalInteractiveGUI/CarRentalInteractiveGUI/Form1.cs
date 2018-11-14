using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double daysRented;
            double milesDriven;
            double daysCost;
            double milesCost;
            double total;

            daysRented = Convert.ToInt32(txt1.Text);
            milesDriven = Convert.ToInt32(txt2.Text);

            daysCost = daysRented * 20;
            milesCost = milesDriven * .25;
            total = daysCost + milesCost;

            lblDaysCostBox.Text = daysCost.ToString("C");
            lblMilesCostBox.Text = milesCost.ToString("C");
            lblTotalCostBox.Text = total.ToString("C");
        }
    }
}
