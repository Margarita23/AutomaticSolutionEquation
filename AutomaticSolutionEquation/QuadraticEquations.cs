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
            if (a.Text.Trim() == string.Empty || a.Text.Trim() == "0")
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
                MessageBox.Show("Пожалуйста, проверьте аргумент с", "Ошибка");
                return;
            }
            else if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент d", "Ошибка");
                return;
            }
            
            try
            {
                QuadraticEquation qe = new QuadraticEquation(a.Text, textBox2.Text, textBox3.Text, textBox1.Text);
                double?[] res = qe.Solve();
                string result = "";
                foreach (double? i in res)
                {
                    result += " " + Math.Round(Convert.ToDecimal(i), 2) + ";";
                }
                if(res[0] != res[1])
                {
                    label3.Text = "x = " + result;
                }else if(res[0].Equals(null) || res[1].Equals(null))
                {
                    label3.Font = new System.Drawing.Font("Leelawadee", 8);
                    label3.Text = "Уравнение имеет комплексные корни.";
                }
                else
                {
                    label3.Text = "x = " + res[0];
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные.");
            }
        }
    }
}
