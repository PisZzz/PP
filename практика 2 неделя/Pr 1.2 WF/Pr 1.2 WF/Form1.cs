using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1._2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double F(double q, double b, int n, ref double fn)
        {
            if (n == 0) return 0;
            if (n == 1) return q;
            fn *= b;
            return fn + F(q, b, --n, ref fn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double q = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                int n = int.Parse(textBox2.Text);
                double fn = q;
                double sum = 0;
                sum = F(q, b, n, ref fn);
                string s = "fn = " + fn + "\nsum = " + sum;
                label4.Text = s;
            }
            catch
            {
                label4.Text = "Ошибка ввода";
            }
        }
    }
}
