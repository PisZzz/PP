using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3._4_WF
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
                Random rnd = new Random();
                int n = Convert.ToInt32(textBox1.Text);
                int m = Convert.ToInt32(textBox2.Text);

                int[] x = new int[n];
                for (int i = 0; i < n; i++)
                {
                    x[i] = rnd.Next(1, 10);
                    s = s + " "+ x[i];
                }
                label3.Text = "x = " + s;
                s = "";
                int[][] arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[m];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        arr[i][j] = rnd.Next(1, 10);
                        s = s + " " + arr[i][j];
                    }
                    s = s + "\n";
                }
                richTextBox1.Text = s;
                s = "";
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i % 2 != 0)
                        {
                            arr[j][i] = x[j];
                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s = s + " " + arr[i][j];
                    }
                    s = s + "\n";
                }
                richTextBox2.Text = s;
            }
            catch
            {
                label3.Text = "Ошибка ввода";
            }
        }
    }
 }

