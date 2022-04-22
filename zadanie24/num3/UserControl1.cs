using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y - 150);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 150);

        }
    }
}
