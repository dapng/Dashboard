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

namespace Dashboard
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCalender_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double stoimost1, skidka1, stoimost2, skidka2, stoimost3, skidka3,
                stoimost4, skidka4, stoimost5, skidka5, stoimost6, skidka6, stoimost7,
                skidka7;
            stoimost1 = Convert.ToDouble(textBox16.Text);
            skidka1 = Convert.ToDouble(textBox23.Text);
            stoimost2 = Convert.ToDouble(textBox17.Text);
            skidka2 = Convert.ToDouble(textBox24.Text);
            stoimost3 = Convert.ToDouble(textBox18.Text);
            skidka3 = Convert.ToDouble(textBox25.Text);
            stoimost4 = Convert.ToDouble(textBox19.Text);
            skidka4 = Convert.ToDouble(textBox26.Text);
            stoimost5 = Convert.ToDouble(textBox20.Text);
            skidka5 = Convert.ToDouble(textBox27.Text);
            stoimost6 = Convert.ToDouble(textBox21.Text);
            skidka6 = Convert.ToDouble(textBox28.Text);
            stoimost7 = Convert.ToDouble(textBox22.Text);
            skidka7 = Convert.ToDouble(textBox29.Text);
            textBox30.Text = Convert.ToString((stoimost1 - (stoimost1 * skidka1) / 100));
            textBox31.Text = Convert.ToString((stoimost2 - (stoimost2 * skidka2) / 100));
            textBox32.Text = Convert.ToString((stoimost3 - (stoimost3 * skidka3) / 100));
            textBox33.Text = Convert.ToString((stoimost4 - (stoimost4 * skidka4) / 100));
            textBox34.Text = Convert.ToString((stoimost5 - (stoimost5 * skidka5) / 100));
            textBox35.Text = Convert.ToString((stoimost6 - (stoimost6 * skidka6) / 100));
            textBox36.Text = Convert.ToString((stoimost7 - (stoimost7 * skidka7) / 100));
            label11.Text = Convert.ToString("Расчёт окончен!\nРекомендация: импортируйте файл во избежание потери данных, нажав кнопку импорт"); 
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine("Название:\n" + textBox2.Text + " \nСсылка:\n" + textBox9.Text + " \nЦена со скидкой:\n" + textBox30.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox3.Text + " \nСсылка:\n" + textBox10.Text + " \nЦена со скидкой:\n" + textBox31.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox4.Text + " \nСсылка:\n" + textBox11.Text + " \nЦена со скидкой:\n" + textBox32.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox5.Text + " \nСсылка:\n" + textBox10.Text + " \nЦена со скидкой:\n" + textBox33.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox6.Text + " \nСсылка:\n" + textBox11.Text + " \nЦена со скидкой:\n" + textBox34.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox7.Text + " \nСсылка:\n" + textBox12.Text + " \nЦена со скидкой:\n" + textBox35.Text + "\n\n");
                streamWriter.WriteLine("Название:\n" + textBox8.Text + " \nСсылка:\n" + textBox13.Text + " \nЦена со скидкой:\n" + textBox36.Text + "\n\n");

                streamWriter.Close();
                
                
            }
                

        }
    }
}
