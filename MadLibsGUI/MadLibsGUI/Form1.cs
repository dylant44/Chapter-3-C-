using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int color;
            int wordEndEst;
            int bodyPart;
            int animal;
            int noun;
            int pluralNoun;
            int c;

            color = Convert.ToInt32(txt1.Text);
            wordEndEst = Convert.ToInt32(txt2.Text);
            bodyPart = Convert.ToInt32(txt3.Text);
            animal = Convert.ToInt32(txt4.Text);
            noun = Convert.ToInt32(txt5.Text);
            pluralNoun = Convert.ToInt32(txt6.Text);
            c = Convert.ToInt32(txt7);

            lblStoryBox.Text = "The " + color + " Dragon is the " + wordEndEst + " Dragon of all. It has " + c + " " + bodyPart + ", and a " + animal + " shaped like a " + noun + ". It loves to eat " + pluralNoun + ", although it will feast on nearly anything.";

        }
    }
}
