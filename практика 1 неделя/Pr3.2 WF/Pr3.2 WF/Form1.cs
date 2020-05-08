﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr3._2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double y;
            if (Math.Abs(x) < 3)
                y = Math.Sin(x);
            else if (3 <= Math.Abs(x) && Math.Abs(x) < 9)
            {
                y = Math.Sqrt((x * x) + 1) / Math.Sqrt((x * x) + 5);
            }
            else
                y = Math.Sqrt((x * x) + 1) - Math.Sqrt((x * x) + 5);
            return y;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";

                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
                for (double i = a; i <= b; i += h)
                {
                    str = str + f(i) + "\n";
                }
                label4.Text = str;
            }
            catch
            {
                label4.Text = "Ошибка ввода";
            }
        }
    }
}
