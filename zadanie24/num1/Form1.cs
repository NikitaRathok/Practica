using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int openDocuments = 0;
            switch (e.ClickedItem.Tag.ToString())
            {
                
                case "NewDoc":
                    Form2 f = new Form2();
                    f.MdiParent = this;
                    f.Show();
                    f.Text = f.Text + " " +
                    ++openDocuments;
                    break;
                case "Cascade":
                    this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    this.LayoutMdi
                    (System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}
