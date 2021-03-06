﻿using AutomaticSolutionEquation.EquationsClasses;
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
            try
            {
                SimpleEquation se = new SimpleEquation(a.Text, textBox2.Text, textBox3.Text);
                label3.Text = "x = " + se.Solve();
            }
            catch (FormatException)
            {
                MessageBox.Show("Something is wrong");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
