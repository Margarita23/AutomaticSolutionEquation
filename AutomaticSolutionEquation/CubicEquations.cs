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
    public partial class CubicEquations : Form
    {
        public CubicEquations()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            if (a.Text.Trim() == string.Empty || a.Text.Trim() == "0")
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент a", "Ошибка");
                return;
            }
            else if (b.Text.Trim() == string.Empty || b.Text.Trim() == "0")
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент a", "Ошибка");
                return;
            }
            else if (c.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент b", "Ошибка");
                return;
            }
            else if (d.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент с", "Ошибка");
                return;
            }
            else if (f.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Пожалуйста, проверьте аргумент d", "Ошибка");
                return;
            }

            try
            {
                CubicEquation ce = new CubicEquation(a.Text, b.Text, c.Text, d.Text, f.Text);
                double?[] res = ce.Solve();
          
                string result = "";
                foreach (double? i in res)
                {
                    result += " " + Math.Round(Convert.ToDecimal(i), 2) + ";";
                }
                if (res[1].Equals(null) && res[2].Equals(null))
                {
                    label3.Text = "x = " + Math.Round(Convert.ToDecimal(res[0]), 2);
                }
                else
                {
                    label3.Text = "x = " + result;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные.");
            }
        }
    }
}
