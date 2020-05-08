using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2._3_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            int n = 15;
            int i = 0, a = 0;
            for (i = 0, a = 10; i <= n; i++, a++)
            {
               str = str + a + " " + (a + 0.4) + "\n";
            }
            richTextBox1.Text = str;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "";
            int n = 15;
            int i = 0, a = 10;
            while (i <= n)
            {
                str = str + (a + " " + (a + 0.4)) + "\n";
                i++;
                a++;
            }
            richTextBox1.Text = str;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "";
            int n = 15;
            int i = 0, a = 10;
            do
            {
                str = str + (a + " " + (a + 0.4)) + "\n";
                i++;
                a++;
            } while (i <= n);
            richTextBox1.Text = str;
        }
    }
   
}
