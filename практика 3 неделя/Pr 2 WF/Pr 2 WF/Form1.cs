using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Pr_2_WF
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
                string s = "";
                string text = textBox1.Text + " ";
                int x = int.Parse(textBox2.Text);
                Regex r = new Regex(@"\b(\w){" + x + @"}\b");
                Match words = r.Match(text);
                while (words.Success)
                {
                    s = s + " " + words;
                    words = words.NextMatch();
                }
                label3.Text = s;
            }
            catch
            {
                label3.Text = "Ошибка";
            }
        }
    }
}
