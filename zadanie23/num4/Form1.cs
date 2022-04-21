using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.ToString() == "К")
            {
                //вызываем класс, который создает кнопку
            }
            else if (textBox1.Text.ToString() == "П")
            {

                //вызываем класс, который создает поле ввода
            }
            else if (textBox1.Text.ToString() == "Л")
            {
                //вызываем класс, который создает метку
            }



        }
        public void InputBox()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Size = new Size(300, 150);
            this.Text = "Заголовок";

            
            textBox1.Size = new Size(250, 25);
            textBox1.Font = new Font(TextBox.DefaultFont, FontStyle.Regular);
            textBox1.Location = new Point(20, 50);

            this.Controls.Add(textBox1);

            textBox1.Show();

            textBox1.KeyPress += new KeyPressEventHandler(textBox_KeyPress);

            Label label = new Label();
            label.AutoSize = false;
            label.Size = new Size(250, 25);
            label.Font = new Font(label.Font, FontStyle.Regular);
            label.Location = new Point(20, 25);
            label.Text = "Введите новое значение:  ";

            this.Controls.Add(label);

            label.Show();

            Button buttonOK = new Button();
            buttonOK.Size = new Size(80, 25);
            buttonOK.Location = new Point(105, 75);
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            buttonOK.Text = "OK";

            this.Controls.Add(buttonOK);

            buttonOK.Show();

            Button buttonCancel = new Button();
            buttonCancel.Size = new Size(80, 25);
            buttonCancel.Location = new Point(190, 75);
            buttonCancel.Text = "Cancel";

            this.Controls.Add(buttonCancel);

            buttonCancel.Show();

            buttonCancel.Click += new EventHandler(buttonCancel_Click);
        }

        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;

                this.Close();
            }
        }

        public void buttonCancel_Click(object sander, EventArgs e)
        {
            this.Close();
        }

        public string getString()
        {
            if (this.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return null;
            return textBox1.Text;
        }
    }
}

