using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr3._1_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double max(double a, double b)
        {
            return (a > b) ? a : b;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = Convert.ToDouble(textBox2.Text);
                double z = max(x, (2 * y - x)) + max(5 * x + 3 * y, y);
                label3.Text = "z = " + z;
            }
            catch
            {
                label3.Text = "Ошибка ввода";
            }
        }
    }
}
