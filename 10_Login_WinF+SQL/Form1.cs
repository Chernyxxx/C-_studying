using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace _10_Login_WinF_SQL
{
    public partial class Form1 : Form
    {

        private SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["KeyName"].ConnectionString);
            sqlConnection.Open();                   
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            string enteredLogin = login_field.Text;
            string enteredPassword = pass_field.Text;

            SqlCommand command = new SqlCommand($"SELECT * FROM Users WHERE Password='{enteredPassword}' AND Login ='{enteredLogin}'", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {               
                MessageBox.Show($"Добро пожоловать {reader["First_name"]} {reader["Last_name"]}");
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
            
            reader.Close();

            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();               
            }
            this.Close();
        }
    }
}
