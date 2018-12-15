using AutomaticSolutionEquation.EquationsClasses;
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
    public partial class SimpleEquations : Form
    {
        public SimpleEquations()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SimpleEquation se = new SimpleEquation("1", "2", "3");

            bool validTextBoxes = 
                (textBox2.Text.Trim() == string.Empty) || (textBox3.Text.Trim() == string.Empty);
            if (a.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент a", "Ошибка");
                return;
            } else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент b", "Ошибка");
                return;
            }
            else if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент c", "Ошибка");
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
