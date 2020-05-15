using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3._1
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
                string s = "";
                int n, a, b;
                n = Convert.ToInt32(textBox1.Text);
                a = Convert.ToInt32(textBox2.Text) - 1;
                b = Convert.ToInt32(textBox3.Text) - 1;
                int[] mass = new int[n];
                Random rnd = new Random();
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(100);
                    s = s + " " + mass[i];
                }
                label4.Text = s;
                for (int i = a; i <= b; i++)
                {
                    mass[i] = 0;
                }
                s = "";
                for (int i = 0; i < mass.Length; i++)
                {
                    s = s + " " + mass[i] + " ";
                }
                label5.Text = s;
            }
            catch
            {
                label5.Text = "Ошибка ввода";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                Random rnd = new Random();
                int n = Convert.ToInt32(textBox4.Text);
                int m = Convert.ToInt32(textBox5.Text);
                int ax = Convert.ToInt32(textBox6.Text) - 1;
                int ay = Convert.ToInt32(textBox7.Text) - 1;
                int bx = Convert.ToInt32(textBox8.Text) - 1;
                int by = Convert.ToInt32(textBox9.Text) - 1;

                int[,] arr = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i, j] = rnd.Next(1, 10);
                        s = s + " " + arr[i, j];
                    }
                    s = s + "\n";
                }
                richTextBox1.Text = s;
                s = "";
                for (int i = ay; i <= by; i++)
                {
                    for (int j = ax; j <= bx; j++)
                    {
                        arr[i, j] = 0;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s = s + " " + arr[i, j];
                    }
                    s = s + "\n";
                }
                richTextBox2.Text = s;
            }
            catch
            {
                richTextBox1.Text = "Ошибка";
                richTextBox2.Text = "Ошибка";
            }
        }
    }
}
