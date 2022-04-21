using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            string[] mas = new string[12]
            {
                "январь","февраль","март","апрель","май","июнь","июль","август","сентябрь","октябрь","ноябрь","декабрь"
            };
            foreach (var a in mas)
            {
                comboBox2.Items.Add(a);
            }
            for (int i = 1970; i <= 2022; i++)
            {
                comboBox3.Items.Add(i);
            }
            string[] masG = new string[6] { "Гродно", "Брест", "Гомель", "Витебск", "Могилёв", "Минск" };

            comboBox4.Items.AddRange(masG);

            string[] masNum = new string[3] { "Life", "MTS", "A1" };
            comboBox5.Items.AddRange(masNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.DefaultExt = "*.txt";
            saveFile1.Filter = "Text files|*.txt";
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
                saveFile1.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(saveFile1.FileName, true))
                {
                    sw.WriteLine($"Фамилия: {textBox1.Text}");


                    sw.WriteLine($"Имя: {textBox2.Text}");
                    sw.WriteLine($"Отчество: {textBox2.Text}");
                    if (radioButton1.Checked == false)
                    {
                        sw.WriteLine("Пол женский");
                    }
                    if (radioButton2.Checked == false)
                    {
                        sw.WriteLine("Пол мужской");
                    }
                    sw.WriteLine(comboBox1.Text);
                    sw.WriteLine(comboBox2.Text);
                    sw.WriteLine(comboBox3.Text);
                    sw.WriteLine(comboBox4.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.WriteLine(comboBox5.Text);
                    sw.WriteLine(textBox5.Text);
                    if (radioButton3.Checked == false)
                    {
                        sw.WriteLine("Прежде не работал");
                    }
                    if (radioButton4.Checked == false)
                    {
                        sw.WriteLine("Меньше 1 года");
                    }
                    if (radioButton5.Checked == false)
                    {
                        sw.WriteLine("От 1 года до 5");
                    }
                    if (radioButton6.Checked == false)
                    {
                        sw.WriteLine("ОТ 5 до 9 лет");
                    }
                    if(radioButton7.Checked == false)
                    {
                        sw.WriteLine("10 лет и более");
                    }
                    if(checkBox1.Checked == true)
                    {
                        sw.WriteLine(checkBox1.Text);
                    }
                    if(checkBox2.Checked == true)
                    {
                        sw.WriteLine(checkBox2.Text);
                    }
                    if(checkBox3.Checked == true)
                    {
                        sw.WriteLine(checkBox3.Text);
                    }
                    if(checkBox4.Checked == true)
                    {
                        sw.WriteLine(checkBox4.Text);
                    }
                    if(checkBox5.Checked == true)
                    {
                        sw.WriteLine(checkBox5.Text);
                    }
                    
                    if(checkBox6.Checked == true)
                    {
                        sw.WriteLine(checkBox6.Text);
                    }
                    
                    sw.WriteLine(numericUpDown1.Value);
                    sw.WriteLine(numericUpDown2.Value);
                    if(radioButton8.Checked == false)
                    {
                        sw.WriteLine("Плотная занятость");
                    }
                    if(radioButton10.Checked ==  false)
                    {
                        sw.WriteLine("работа на дому");
                    }
                    if(radioButton11.Checked == false)
                    {
                        sw.WriteLine("Частичная занятость");
                    }
                    if(radioButton12.Checked == false)
                    {
                        sw.WriteLine("посменная работа");
                    }

                    sw.WriteLine("Краткое резюмец" + textBox6.Text);

                    sw.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            radioButton1.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox5.ResetText();
        }
    }
}
