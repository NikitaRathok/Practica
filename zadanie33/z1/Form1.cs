using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using z1.Models;

namespace z1
{
    public partial class Form1 : Form
    {
        SqlConnection _connection = new SqlConnection(
            "Data Source=SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True");

        public string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            printTour();
        }


        public void printTour()
        {
            DataContext db = new DataContext(_connection);

            Table<Turst> turists = db.GetTable<Turst>();

            foreach (var turist in turists)
            {
                textBox1.Text += turist.Surname;
                textBox1.Text += turist.FirstName;
                textBox1.Text += turist.LastName;
            }
        }

        public void deleteTourist()
        {
            DataContext db = new DataContext(_connection);
            var tourist = db.GetTable<Turst>().OrderByDescending(u => u.OneName).FirstOrDefault();

            if (tourist != null)
            {
                db.GetTable<Turst>().DeleteOnSubmit(tourist);
            }
        }

        public void addTourist()
        {
            DataContext db = new DataContext(_connection);
            Turst tourist = new Turst { FirstName = "Валерьевич", OneName = "Павел", Surname = "Дуров" };
            db.GetTable<Turst>().InsertOnSubmit(tourist);
            db.SubmitChanges();
        }
    }
}
