using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2._4_WF
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
                for (int j = 0; j < 5; j++)
                {
                    for (int k = -10; k <= 12; str = str + k++ + " ") ;
                    str = str + "\n";
                }
                richTextBox1.Text = str;
            
        }
    }
}
