using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получаем тип по имени.
            Type t = Type.GetType("Praktika_12." + textBox1.Text);
            // Создаем переменную по типу.
            ISomeInterface w = (Praktika_12.ISomeInterface)Activator.CreateInstance(t);
            // Вызываем метод.
            w.SomeMethod();

        }
    }
    public interface ISomeInterface
    {
        void SomeMethod();
    }
    public class Class1 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class1");
        }
    }

    public class Class2 : ISomeInterface
    {
        public void SomeMethod()
        {
            System.Windows.Forms.MessageBox.Show("Class2");
        }
    }

}
