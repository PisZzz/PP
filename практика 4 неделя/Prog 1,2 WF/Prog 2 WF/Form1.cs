using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Triangle triangle = new Triangle();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                triangle.a = Convert.ToInt32(textBox1.Text);
                triangle.b = Convert.ToInt32(textBox2.Text);
                triangle.c = Convert.ToInt32(textBox3.Text);
                label4.Text = triangle.Print();
            }
            catch
            {
                label4.Text = "Ошибка ввода";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                triangle.A = Convert.ToInt32(textBox1.Text);
                triangle.B = Convert.ToInt32(textBox2.Text);
                triangle.C = Convert.ToInt32(textBox3.Text);
                label4.Text = triangle.Print();
            }
            catch
            {
                label4.Text = "Ошибка ввода";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(triangle.P());
            textBox5.Text = Convert.ToString(triangle.S());
            label4.Text = triangle.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (triangle.isTriangle)
                label7.Text = "Треугольник существует";
            else
                label7.Text = "Треугольник не существует";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(numericUpDown1.Value);
                triangle[i] = Convert.ToInt32(textBox6.Text);
                label4.Text = triangle.Print();
            }
            catch
            {
                label4.Text = "Ошибка ввода";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ++triangle;
            label4.Text = triangle.Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            --triangle;
            label4.Text = triangle.Print();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(numericUpDown2.Value);
            triangle *= i;
            label4.Text = triangle.Print();
        }


    }
}
