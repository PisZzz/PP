using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr1._2_WF
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
                int x = 0;
                x = Convert.ToInt32(textBox1.Text);
                if (x % 2 != 0)
                    label2.Text = "Число нечётное";
                else
                    label2.Text = "";
            }
            catch
            {
                label2.Text = "Ошибка ввода";
            }
        }
    }
}
