using Prog_3_WF;
using System;
using System.Windows.Forms;

namespace prog_3_WF
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox3.Text);
                Line func = new Line(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                label1.Text = "значение функции Line для x = " + Convert.ToString(x) +
                    " равно " + Convert.ToString(func.Count(x));
            }
            catch
            {
                label1.Text = "Ошибка ввода";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox3.Text);
                Kub func = new Kub(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                label5.Text = "значение функции Kub для x = " + Convert.ToString(x) +
                    " равно " + Convert.ToString(func.Count(x));
            }
            catch
            {
                label5.Text = "Ошибка ввода";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox3.Text);
                Hyperbola func = new Hyperbola(Convert.ToInt32(textBox7.Text));
                label9.Text = "значение функции Hyperbola для x = " + Convert.ToString(x) +
                    " равно " + Convert.ToString(func.Count(x));
            }
            catch
            {
                label9.Text = "Ошибка ввода";
            }
        }
    }
}
