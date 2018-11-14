using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int ContestantsThisYear;
            int ContestantsLastYear;
            int RevenueThisYear;
            String MoreOrLess;

            ContestantsThisYear = Convert.ToInt32(txt1.Text);
            ContestantsLastYear = Convert.ToInt32(txt2.Text);

            RevenueThisYear = ContestantsThisYear * 25;

            if(ContestantsThisYear > ContestantsLastYear)
            {
                MoreOrLess = "More";
            }
            else
            {
                MoreOrLess = "Less";
            }
            lblExpectedBox.Text = "" + RevenueThisYear.ToString("C");
            lblBigOrSmallBox.Text = MoreOrLess;
            
        }
    }
}
