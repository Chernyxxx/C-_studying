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
        //
        //                       ЧЕКБОКСЫ
        //
        //
        //             

        private void checkBox_insert_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_insert.Checked == true)
            {
                checkBox_delete.Checked = false;
                checkBox_update.Checked = false;
                checkBox_search.Checked = false;

                insert_butt.Enabled = true;
                delete_butt.Enabled = false;
                update_butt.Enabled = false;
                search_butt.Enabled = false;

                id_textBox.Enabled = false;
                login_textBox.Enabled = true;
                password_textBox.Enabled = true;
                fName_textBox.Enabled = true;
                lName_textBox.Enabled = true;
            }                   
        }
        private void checkBox_delete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_delete.Checked == true)
            {
                checkBox_insert.Checked = false;
                checkBox_update.Checked = false;
                checkBox_search.Checked = false;

                delete_butt.Enabled = true;
                insert_butt.Enabled = false;
                update_butt.Enabled = false;
                search_butt.Enabled = false;

                id_textBox.Enabled = true;
                login_textBox.Enabled = false;
                password_textBox.Enabled = false;
                fName_textBox.Enabled = false;
                lName_textBox.Enabled = false;
            }
        }

        private void checkBox_update_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_update.Checked == true)
            {
                checkBox_insert.Checked = false;
                checkBox_delete.Checked = false;
                checkBox_search.Checked = false;

                update_butt.Enabled = true;
                insert_butt.Enabled = false;
                delete_butt.Enabled = false;
                search_butt.Enabled = false;

                id_textBox.Enabled = true;
                login_textBox.Enabled = true;
                password_textBox.Enabled = true;
                fName_textBox.Enabled = true;
                lName_textBox.Enabled = true;
            }
                
        }

        private void checkBox_search_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_search.Checked == true)
            {
                checkBox_insert.Checked = false;
                checkBox_delete.Checked = false;
                checkBox_update.Checked = false;

                search_butt.Enabled = true;
                insert_butt.Enabled = false;
                delete_butt.Enabled = false;
                update_butt.Enabled = false;

                id_textBox.Enabled = true;
                login_textBox.Enabled = true;
                password_textBox.Enabled = false;
                fName_textBox.Enabled = true;
                lName_textBox.Enabled = true;
            }
                
        }
        //
        //               СОЕДИНЕНИЕ И ЗАПОЛНЕНИЕ ЛИСТБОКСА
        //
        //
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
              
                while (reader.Read())
                {
                    string values = $"{ reader["Id"]}\t { reader["Login"]}\t \t{reader["First_name"]}\t\t{reader["Last_name"]}  ";
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
        //
        //                  ОБРАБОТКА НАЖАТИЯ КНОПОК
        //
        //
        //
        //                      Кнопка INSERT 
        //
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
            
            login_textBox.Text = "";
            password_textBox.Text = "";
            fName_textBox.Text = "";
            lName_textBox.Text = "";
        }
        //
        //           Кнопка DELETE - удаление по Id
        //
        private void delete_butt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_textBox.Text);
            string cmdText = $"DELETE FROM Users WHERE Id ={id}";
            SqlCommand command = new SqlCommand(cmdText, connection);
            
            command.ExecuteNonQuery();
            MessageBox.Show($"Пользователь '{login_textBox.Text}' удалён");
            id_textBox.Text = "";
        }
        //
        //              Кнопка UPDATE - обновить по Id
        //
        private void update_butt_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(id_textBox.Text);
            string cmdText = $"UPDATE Users SET Login = '{login_textBox.Text}', Password ='{password_textBox.Text}', First_name = '{fName_textBox.Text}', Last_name ='{lName_textBox.Text}' WHERE Id ={id}";
            SqlCommand command = new SqlCommand(cmdText, connection);

            command.ExecuteNonQuery();
            MessageBox.Show($"Изменены данные пользователя Id = '{id_textBox.Text}'");

            id_textBox.Text = "";
            login_textBox.Text = "";
            password_textBox.Text = "";
            fName_textBox.Text = "";
            lName_textBox.Text = "";
        }
        //
        //              Кнопка SEARCH - искать по любым данным
        //
        private void search_butt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int id = 0;

            if (id_textBox.Text !="")
            {
                id = Convert.ToInt32(id_textBox.Text);
            }
            
            string cmdText = $"SELECT * FROM Users WHERE Id={id} OR Login='{login_textBox.Text}' OR First_name = '{fName_textBox.Text}' OR Last_name = '{lName_textBox.Text}'";
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                
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

            id_textBox.Text = "";
            login_textBox.Text = "";
            password_textBox.Text = "";
            fName_textBox.Text = "";
            lName_textBox.Text = "";
        }

        //
        //                     Кнопка SHOW ALL
        //
        private void showAll_butt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string cmdText = "SELECT * FROM Users ";
            SqlCommand command = new SqlCommand(cmdText, connection);
            SqlDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string values = $"{ reader["Id"]}\t { reader["Login"]}\t \t{reader["First_name"]}\t\t{reader["Last_name"]}  ";
                    listBox1.Items.Add(values);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
