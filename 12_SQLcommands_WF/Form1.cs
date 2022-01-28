using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _12_SQLcommands_WF
{
    public partial class Form1 : Form
    {
        private SqlConnection connection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\C#\\12_SQLcommands_WF\\Database1.mdf;Integrated Security=True");
            connection.Open();
            if (connection.State==ConnectionState.Open)
            {
               // MessageBox.Show("Соединение установлено"); 
            }
            else
            {
                MessageBox.Show("Соединение не установлено");
            }

            string cmdText = "SELECT * FROM Users ";
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
               // string colomns = $"{reader.GetName(0)}\t \t{reader.GetName(1)}\t\t {reader.GetName(3)}\t {reader.GetName(4)}";
               // listBox1.Items.Add(colomns);
                while (reader.Read())
                {
                    string values = $"{ reader["Id"]}\t\t { reader["Login"]}\t \t{reader["First_name"]} \t\t{reader["Last_name"]}  ";
                    listBox1.Items.Add(values);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (reader!= null)
                    reader.Close();
            }

            
        }

        private void insert_butt_Click(object sender, EventArgs e)
        {
            string cmdText = $"INSERT INTO Users (Login, Password, First_name, Last_name) VALUES ('{login_textBox.Text}', '{password_textBox.Text}','{fName_textBox.Text}', '{lName_textBox.Text}')";

            SqlCommand command = new SqlCommand(cmdText, connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добавлен новый пользователь");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delete_butt_Click(object sender, EventArgs e)
        {
            string cmdText = $"DELETE FROM Users WHERE Login ='{login_textBox.Text}'";
            SqlCommand command = new SqlCommand(cmdText, connection);
            
            command.ExecuteNonQuery();
            MessageBox.Show($"Пользователь '{login_textBox.Text}' удалён");
            
        }

        private void search_butt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cmdText = $"SELECT * FROM Users WHERE Login='{login_textBox.Text}' OR First_name = '{fName_textBox.Text}' OR Last_name = '{lName_textBox.Text}'";
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                // string colomns = $"{reader.GetName(0)}\t \t{reader.GetName(1)}\t\t {reader.GetName(3)}\t {reader.GetName(4)}";
                // listBox1.Items.Add(colomns);
                while (reader.Read())
                {
                    string values = $"{ reader["Id"]}\t\t { reader["Login"]}\t \t{reader["First_name"]} \t\t{reader["Last_name"]}  ";
                    listBox1.Items.Add(values);
                }

            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
            reader.Close();

        }

        private void update_butt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_textBox.Text);
            string cmdText = $"UPDATE Users SET Login = '{login_textBox.Text}', Password ='{password_textBox.Text}', First_name = '{fName_textBox.Text}', Last_name ='{lName_textBox.Text}' WHERE Id ={id}";
            SqlCommand command = new SqlCommand(cmdText, connection);
           
            command.ExecuteNonQuery();
            MessageBox.Show($"Изменены данные пользователя Id = '{id_textBox.Text}'");
                        
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
