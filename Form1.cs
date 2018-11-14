using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometersGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            double num1;
            double converted;

            num1 = Convert.ToInt32(txt1.Text);

            converted = num1 * 1.6;
            lblKilometers.Text = converted + " Km";
        }
    }
}
