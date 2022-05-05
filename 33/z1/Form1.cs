using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Data.Common;
using System.Data.SqlClient;

namespace z1
{
    public partial class Form1 : Form
    {
        MySqlConnection _connection = new MySqlConnection(
            "server=localhost;username=mysql;database=dbtur_firm");

        public string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            _connection.Open();

            printTour();
            printTourist();

            _connection.Close();
        }


        public void printTour()
        {
            sql = "SELECT * FROM `туры`";
            MySqlCommand command = new MySqlCommand(sql, _connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);   

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    textBox1.Text += column.ColumnName + 
                        Environment.NewLine;
                }

                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;

                    foreach (object cell in cells)
                    {
                        textBox1.Text += cell +
                            Environment.NewLine;
                    }
                }
            }
        }

        public void printTourist()
        {
            sql = "SELECT * FROM `туристы`";
            MySqlCommand command = new MySqlCommand(sql, _connection);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataColumn column in dt.Columns)
                {
                    textBox1.Text += column.ColumnName +
                        Environment.NewLine;
                }

                foreach (DataRow row in dt.Rows)
                {
                    var cells = row.ItemArray;

                    foreach (object cell in cells)
                    {
                        textBox1.Text += cell +
                            Environment.NewLine;
                    }
                }
            }
        }

        public void deleteTour()
        {
            sql = "DELETE FROM `тур` WHERE `код тура` = 2 LIMIT 1";
            MySqlCommand command = new MySqlCommand(sql, _connection);

            command.ExecuteNonQuery();
        }

        public void addTourist()
        {
            var ID = 3;
            var _surname = "Дуров";
            var _name = "Павел";
            var _sname = "Валерьевич";

            string _sql = string.Format("INSERT INTO Туристы (Код, Фамилия, Имя, Отчество)" +
                "VALUES (@ID, @_surname, @_name, @_sname)");

            MySqlCommand _command = new MySqlCommand(_sql, _connection);

            _command.Parameters.AddWithValue("@ID", ID);
            _command.Parameters.AddWithValue("@_surname", _surname);
            _command.Parameters.AddWithValue("@_name", _name);
            _command.Parameters.AddWithValue("@_sname", _sname);

            _command.ExecuteNonQuery();
        }

        public void updateTourist()
        {
            string _sql = "UPDATE Туристы SET Имя='Виталий' WHERE Код=2";
            MySqlCommand _command = new MySqlCommand(_sql, _connection);

            _command.ExecuteNonQuery();
        }
    }
}
