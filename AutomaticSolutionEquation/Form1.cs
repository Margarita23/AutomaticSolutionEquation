using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticSolutionEquation
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

        private void button1_Click(object sender, EventArgs e)
        {
            SimpleEquations se = new SimpleEquations();
            se.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuadraticEquations qe = new QuadraticEquations();
            qe.Show();
        }
    }
}
