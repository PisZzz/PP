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
    public partial class lgotForm : Form
    {
        public lgotForm()
        {
            InitializeComponent();
        }

        private void lgotForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "бДDataSet.Lgota". При необходимости она может быть перемещена или удалена.
            this.lgotaTableAdapter.Fill(this.бДDataSet.Lgota);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lgotaTableAdapter.Update(бДDataSet);
        }
    }
}
