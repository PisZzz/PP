using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr_2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x)
        {
            try
            {
                if (x == -1)
                    throw new Exception();
                else
                    return Math.Pow(Math.E, (((x - 1) * (x - 1)) / x));
            }
            catch
            {
                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string s = "";
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double h = double.Parse(textBox3.Text);
            
                if (a > b)
                    throw new Exception();
                
                if (h < 1)
                    throw new ArithmeticException();
                    
                for (double i = a; i <= b; i += h)
                    try
                    {
                        s = s + "\n" + Convert.ToString(i + f(i));
                    }
                    catch
                    {
                        label4.Text = "y error" + i;
                    }
                label4.Text = s;
            }
            catch (FormatException)
            {
                label4.Text = "Неверный формат ввода данных";
            }
            catch(Exception)
            {
                label4.Text = "a должно быть меньше b\n h должен быть больше 0";
            }      
        }
    }
}
