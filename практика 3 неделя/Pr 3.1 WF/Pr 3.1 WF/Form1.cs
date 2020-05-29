using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Pr_3._1_WF
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
                string path = @"D:\123.txt";
                string buffer = "";
                int n = int.Parse(textBox1.Text);
                double x = 0, j = 1;
                for (int i = 0; i < n; i++)
                {
                    x = 1 / j++;
                    buffer = buffer + Convert.ToString(x) + ";";
                }
                File.WriteAllText(path, buffer);
                string[] file = File.ReadAllLines(path);
                string[] buf = file[0].Split(';');
                for (int i = 0; i < n; i++)
                {
                    if (i % 3 == 0)
                        s = s +"\n"+ buf[i];
                }
                label2.Text = s;
            }
            catch
            {
                label2.Text = "Ошибка ввода";
            }
        }
    }
}
