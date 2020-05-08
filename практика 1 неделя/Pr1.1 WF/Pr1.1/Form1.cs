using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double a, b, c, d;
                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);
                label5.Text = "\nРасстояние между точками а, b = " + Math.Abs(a - b)
                    + "\nРасстояние между точками c, d = " + Math.Abs(c - d);
            }
            catch
            {
                label5.Text = "Ошибка ввода";
            }
            
        }
    }
}
