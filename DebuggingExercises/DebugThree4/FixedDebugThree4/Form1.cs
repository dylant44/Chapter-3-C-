﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int birthYear;
            int CurrentYear;
            int age;
            birthYear = Convert.ToInt32(textBox1.Text);
            CurrentYear = Convert.ToInt32(textBox2.Text);
            age = CurrentYear - birthYear;
            lblOutput.Text = String.Format("On your birthday this year, \nyou were or will be " +
                "{0} years old", age);
        }
    }
}
