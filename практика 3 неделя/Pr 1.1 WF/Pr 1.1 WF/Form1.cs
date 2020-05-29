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

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                StringBuilder sb = new StringBuilder(textBox1.Text);
                char s1 = char.Parse(textBox2.Text);
                char s2 = char.Parse(textBox3.Text);
                int amount1 = 0, amount2 = 0;
                for (int i = 0; i < sb.Length; i++)
                {
                    if (sb[i] == s1)
                        amount1++;
                    if (sb[i] == s2)
                        amount2++;
                }
                if (amount1 > amount2)
                   label4.Text = s1 + " > " + s2;
                else if (amount1 < amount2)
                    label4.Text = s2 + " > " + s1;
                else
                    label4.Text = s2 + " = " + s1;
            }
            catch
            {
                 label4.Text = "Ошибка ввода";
            }
        }
    }
}
