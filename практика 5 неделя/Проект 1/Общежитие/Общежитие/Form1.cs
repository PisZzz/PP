using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Общежитие
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            roomsForm form2 = new roomsForm();
            form2.Text = "Комнаты";
            form2.ShowDialog();
        }

        private void льготаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lgotForm form3 = new lgotForm();
            form3.Text = "Льготы";
            form3.ShowDialog();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentsForm form4 = new StudentsForm();
            form4.Text = "Студенты";
            form4.ShowDialog();
        }

        private void расселениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RasselenieForm form5 = new RasselenieForm();
            form5.Text = "Расселение";
            form5.ShowDialog();
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZaprosForm form6 = new ZaprosForm();
            form6.Text = "Запрос";
            form6.ShowDialog();
        }

        private void отчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Otchet form7 = new Otchet();
            form7.Text = "Отчёт";
            form7.ShowDialog();
        }
    }
}
