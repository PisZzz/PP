using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_1._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double n(int x)
        {
            return x == 1 ? 5 : n(x - 1) * (x * x + x + 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = int.Parse(textBox1.Text);
                label2.Text = Convert.ToString(n(n1));
            }
            catch
            {
                label2.Text = "Ошибка ввода";
            }
        }
    }
}
