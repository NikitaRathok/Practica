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
                Button b = new Button();
                b.MouseMove += B_MouseMove;
                b.Text = "Кнопка";
                this.Controls.Add(b);
                b.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                b.BackColor = Color.Pink;
                b.Show();
                
                
            }
            else if (textBox1.Text.ToString() == "П")
            {

                TextBox t = new TextBox();
                t.MouseMove += T_MouseMove;
                t.Text = "Текстовое поле";
                this.Controls.Add(t);
                t.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                t.BackColor = Color.Red;
                t.Show();
            }
            else if (textBox1.Text.ToString() == "Л")
            {
                Label l = new Label();
                l.MouseMove += L_MouseMove;
                l.Text = "Метка";
                this.Controls.Add(l);
                l.Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                l.BackColor = Color.Green;
                l.Show();
            }



        }

        private void B_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            b.Dispose();
        }

        private void T_MouseMove(object sender, MouseEventArgs e)
        {
            TextBox t = (TextBox)sender;
            t.Dispose();
        }

        private void L_MouseMove(object sender, MouseEventArgs e)
        {
            Label l = (Label)sender;
            l.Dispose();
        }
    }
}

