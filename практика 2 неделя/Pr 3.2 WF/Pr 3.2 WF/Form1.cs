using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_3._2_WF
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
                int n;
                n = Convert.ToInt32(textBox1.Text);
                int[] mass = new int[n];
                int max = mass[0];
                for (int i = 0; i < mass.Length; i++)
                {
                    mass[i] = rnd.Next(1,10);
                    if (max < mass[i])
                        max = mass[i];
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    s = s + " " + mass[i];
                }
                label2.Text = s;
                s = "";
                for (int i = 0; i < mass.Length; i++)
                {
                    if (mass[i] == max)
                        mass[i] = 0;
                    s = s + " " + mass[i];
                }
                label3.Text = s;
            }
            catch
            {
                label3.Text = "Ошибка ввода";
            }
        }
    }
}
