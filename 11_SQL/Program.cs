//
//              1. Создание базы данных
//              2. Подключение к базе данных
//              3. Команды, создание таблицы.
//
//

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //              1. Создание базы данных
            // К проекту Добавить -> Создать элемент ->
            // Базы данных основанные на службах.
            //
            //
            //              2. Подключение к базе данных
            //              
            
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\C#\\11_SQL\\Database1.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                //
                // Свойства  SqlConnection
                //
                connection.Open();
                Console.WriteLine("Подключение открыто");
                Console.WriteLine($"Строка подключения \n { connection.ConnectionString}");
                Console.WriteLine($"База данных \t {connection.Database}");
                Console.WriteLine($"Сервер \t { connection.DataSource}");
                Console.WriteLine($"Версия сервера \t { connection.ServerVersion}");
                Console.WriteLine($"Состояние \t { connection.State}");
                Console.WriteLine($"Сервер WorkstationId \t { connection.WorkstationId}");

                //
                //      3. Команды, создание таблицы.
                // 

                SqlCommand command = new SqlCommand();
                command.CommandText = "CREATE TABLE Staff(Id INT PRIMARY KEY IDENTITY, LOGIN NVARCHAR(32) NOT NULL, PASSWORD NVARCHAR(32) NOT NULL)";
                command.Connection = connection;

                // Выполнение команды
                command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Подключение закрыто");
                }
            }
            Console.WriteLine("Программа завершила работу");
        }
    }
}
