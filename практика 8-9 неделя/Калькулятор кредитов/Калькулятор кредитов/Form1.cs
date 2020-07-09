using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор_кредитов
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox2.SelectedItem = "год";
            comboBox1.SelectedItem = "RUB";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            label4.Text = "";
            label8.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "RUB") { label4.Text = "RUB"; }
                else if (comboBox1.Text == "USD") { label4.Text = "USD"; }
                else if (comboBox1.Text == "EUR") { label4.Text = "EUR"; }

                double sumKred = Convert.ToInt32(textBox1.Text);
                double procStav = Convert.ToDouble(textBox3.Text);
                int srokKred = 0;

                double vs = 0;
                double vd = 0;

                int year = monthCalendar1.SelectionEnd.Year;
                int yearDay = 0;

                if (DateTime.IsLeapYear(year))
                {
                    yearDay = 366;
                }
                else
                {
                    yearDay = 365;
                }
                int mouth = monthCalendar1.SelectionEnd.Month;
                int mouthDay = DateTime.DaysInMonth(year, mouth);

                DateTime date1 = new DateTime(year, mouth, 20);



                // расчёт месяцов
                if (comboBox2.Text == "год")
                {
                    srokKred = 12 * Convert.ToInt32(textBox2.Text);
                }
                else
                {
                    srokKred = Convert.ToInt32(textBox2.Text);
                }
                //аннуитетный 
                if (radioButton1.Checked)
                {
                    double osnDolg = sumKred / srokKred;


                    double mouthRate = (procStav / 100) / 12; //Месячная процентная ставка

                    //коэффициент аннуитета
                    double kofAnun = (mouthRate * Math.Pow((1 + mouthRate), srokKred)) / (Math.Pow((1 + mouthRate), srokKred) - 1);

                    //подставляем коэффициент аннуитета в расчет платежа
                    double plat = sumKred * kofAnun;

                    for (int i = 0; i < srokKred; i++)
                    {
                        if (mouth == 12)
                        {
                            mouth = 1;
                            year++;
                        }
                        dataGridView1.Rows.Add();
                        if (mouth < 10)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString("0" + mouth + "." + year);
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(mouth + "." + year);
                        }
                        dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(plat);
                        vs += plat;
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToString(plat - (sumKred * mouthRate));
                        vd = vd + (plat - (sumKred * mouthRate));
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToString(sumKred * mouthRate);
                        sumKred = sumKred - (plat - (sumKred * mouthRate));
                        if (i == srokKred - 1)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = Convert.ToString(0);
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[4].Value = Convert.ToString(sumKred);
                        }
                        mouth++;
                        dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    }
                }//дифференцированный
                else
                {
                    //Часть основного долга
                    double osnDolg = sumKred / srokKred;

                    //Сумма процентов
                    double summProc = (sumKred * (procStav / 100) * mouthDay) / yearDay;
                    dataGridView1.Rows.Add();
                    if (mouth < 10)
                    {
                        dataGridView1.Rows[0].Cells[0].Value = Convert.ToString("0" + mouth + "." + year);
                    }
                    else
                    {
                        dataGridView1.Rows[0].Cells[0].Value = Convert.ToString(mouth + "." + year);
                    }
                    dataGridView1.Rows[0].Cells[1].Value = Convert.ToString(osnDolg + summProc);
                    vs = vs + osnDolg + summProc;
                    dataGridView1.Rows[0].Cells[2].Value = Convert.ToString(osnDolg);
                    vd += osnDolg;
                    dataGridView1.Rows[0].Cells[3].Value = Convert.ToString(summProc);
                    dataGridView1.Rows[0].Cells[4].Value = Convert.ToString(sumKred - osnDolg);
                    mouth++;
                    dataGridView1.Rows[0].HeaderCell.Value = (0 + 1).ToString();
                    for (int i = 1; i < srokKred; i++)
                    {
                        sumKred -= osnDolg;
                        if (mouth == 12)
                        {
                            mouth = 1;
                            year++;
                        }
                        mouthDay = DateTime.DaysInMonth(year, mouth);

                        if (DateTime.IsLeapYear(year))
                        {
                            yearDay = 366;
                        }
                        else
                        {
                            yearDay = 365;
                        }

                        summProc = (sumKred * (procStav / 100) * mouthDay) / yearDay;
                        dataGridView1.Rows.Add();
                        if (mouth < 10)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString("0" + mouth + "." + year);
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(mouth + "." + year);
                        }

                        dataGridView1.Rows[i].Cells[1].Value = Convert.ToString(osnDolg + summProc);
                        vs = vs + osnDolg + summProc;
                        dataGridView1.Rows[i].Cells[2].Value = Convert.ToString(osnDolg);
                        vd += osnDolg;
                        dataGridView1.Rows[i].Cells[3].Value = Convert.ToString(summProc);
                        if (i == srokKred - 1)
                        {
                            dataGridView1.Rows[i].Cells[4].Value = Convert.ToString(0);
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[4].Value = Convert.ToString(sumKred - osnDolg);
                        }
                        mouth++;
                        dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    }

                }
                label8.Text = "";
                textBox4.Text = Convert.ToString(vs);
                textBox5.Text = Convert.ToString(vs - vd);
            }
            catch { label8.Text = "Некорректный ввод"; }
        }
    }
}
