using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pr_3._2_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\123.txt";

            string[] file = File.ReadAllLines(path);
            string buf = file[0];
            int length = file[0].Length;
            for (int i = 0; i < file.Length; i++)
            {
                if (buf.Length < file[i].Length)
                {
                    length = file[i].Length;
                    buf = file[i];
                }
            }
            label1.Text = "Самая длинная строка содержит " + length + " символов:\n" + buf;
        }
    }
}
