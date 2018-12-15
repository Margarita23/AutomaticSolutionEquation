using System;
using AutomaticSolutionEquation.EquationsClasses;
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
    public partial class QuadraticEquations : Form
    {
        public QuadraticEquations()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент a", "Ошибка");
                return;
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент b", "Ошибка");
                return;
            }
            else if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент c", "Ошибка");
                return;
            }
            try
            {
                QuadraticEquation se = new QuadraticEquation(a.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                label3.Text = "x = " + se.Solve();
            }
            catch (FormatException)
            {
                MessageBox.Show("Something is wrong");
            }
        }
    }
}
