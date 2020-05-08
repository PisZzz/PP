using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2._1
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

                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (x * x + y * y < 100 && x * x + y * y > 25)
                    label3.Text = "Да";
                else if (x * x + y * y > 100 || x * x + y * y < 25)
                    label3.Text = "Нет";
                else
                    label3.Text = "На границе";
            }
            catch
            {
                label3.Text = "Ошибка ввода";
            }
        }

    }
}
