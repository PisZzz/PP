using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3._3_WF
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
                Console.Write("n = ");
                int n = Convert.ToInt32(textBox1.Text);
                int[][] arr = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    arr[i] = new int[n];
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        arr[i][j] = rnd.Next(1, 10);
                        s = s +" "+arr[i][j];
                    }
                    s = s + "\n";
                }
                richTextBox1.Text = s;
                int a = 0, b = n - 1;
                int summ = 0;
                while (a != n)
                {
                    summ += arr[b--][a++];
                }
                label2.Text = "Сумма побочной диагонали = " + summ;
            }
            catch
            {
                label2.Text = "Ошибка ввода";
            }
        }
    }
}
