using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num1._2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            spWin.Text = "Windows is horizontal";
            spWin.Text = "Windows is cascade";
            spData.Text =Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

       
    }
}
