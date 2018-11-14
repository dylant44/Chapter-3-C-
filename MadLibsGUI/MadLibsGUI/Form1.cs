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
     
            lblStoryBox.Text = "The " + txtColor.Text + " Dragon is the " + txtWord.Text + " Dragon of all. It has " + txtNumber.Text + " " + txtBody.Text + ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text + ". It loves to eat " + txtPlural.Text + ", although it will feast on nearly anything.";

        }
    }
}
