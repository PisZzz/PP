using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_4
{
    public partial class Form1 : Form
    {
        public int num = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Увеличиваем счетчик пунктов меню.
            num++;
            // Создаем новый подпункт меню.
            // Для него задаем надпись
            // и обработчик выбора пользователем этого пункта.
            ToolStripMenuItem mi = new ToolStripMenuItem(num.ToString());
            mi.Click += this.toolStripMenuItem1_Click;
            // Подсоединяем новый пункт меню к главному меню формы.
            toolStripMenuItem1.DropDownItems.Add(mi);

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Читаем текст на выбранном пользователе пункте меню.
            string s = ((ToolStripMenuItem)sender).Text;
            // Выводим этот текст.
            MessageBox.Show(s);

        }
    }
}
