using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2._2_WF
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
                int n = Convert.ToInt32(textBox1.Text);
                int a = Convert.ToInt32(textBox2.Text);
                switch (n)
                {
                    case 1:
                        label3.Text = "Осталось " + (30 - a);
                        break;
                    case 2:
                        label3.Text = "Если високосный год. Осталось " + (29 - a) + "\nЕсли не високосный год. Осталось " + (28 - a);
                        break;
                    case 3:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    case 4:
                        label3.Text = "Осталось " + (30 - a);
                        break;
                    case 5:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    case 6:
                        label3.Text = "Осталось " + (30 - a);
                        break;
                    case 7:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    case 8:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    case 9:
                        label3.Text = "Осталось " + (30 - a);
                        break;
                    case 10:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    case 11:
                        label3.Text = "Осталось " + (30 - a);
                        break;
                    case 12:
                        label3.Text = "Осталось " + (31 - a);
                        break;
                    default:
                        label3.Text = "нет такого месяца";
                        break;
                }
            }
            catch
            {
                label3.Text = "Ошибка ввода";
            }
        }
    }
}
