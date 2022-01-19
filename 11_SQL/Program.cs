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
            //              
            // 1 вариант
            //
            // К проекту Добавить -> Создать элемент ->
            // Базы данных основанные на службах.
            // 
            // 2 вариант 
            //
            // Сначала подключаемся к MSSQLServer к базе данных master, 
            // которая по умолчанию предустановлена на любом сервере


            /*
            SqlConnection connection = new SqlConnection("Server = (localdb)\\mssqllocaldb;Database = master;Trusted_Connection=True;");
            try
            {
                connection.Open();
                Console.WriteLine("Подключение к БД master");
           //
           // Создаём новоую базу данных
           //
                SqlCommand command = new SqlCommand("CREATE DATABASE Database2", connection);
                command.ExecuteNonQuery();
                Console.WriteLine("База данных Database2 создана"); 
            //
            // Файлы созданой таким образом БД находятся на С/Пользователи/User
            // Требуется прикрепить их к проекту. Для этого скопировать их в папку
            // проекта (возможно не обязательно), добавить в дерево
            // и при выполнении команды вписывать новую строку подключения с
            // параметром AttachDbFilename = E: ...

            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            Console.WriteLine("Подключение закрыто");
            
           */

            // 
            //              2. Подключение к базе данных
            //              
            //              

            //string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\C#\\11_SQL\\Database1.mdf;Integrated Security=True";
            string connectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\C#\\11_SQL\\Database2.mdf;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Подключение    
                connection.Open();
                //
                // Свойства  SqlConnection
                //

                Console.WriteLine("Подключение открыто");
                Console.WriteLine($"Строка подключения \n { connection.ConnectionString}");
                Console.WriteLine($"База данных \t {connection.Database}");
                Console.WriteLine($"Сервер \t { connection.DataSource}");
                Console.WriteLine($"Версия сервера \t { connection.ServerVersion}");
                Console.WriteLine($"Состояние \t { connection.State}");
                Console.WriteLine($"Сервер WorkstationId \t { connection.WorkstationId}");
              
                //
                //      3. Команды, создание таблицы
                // 

                SqlCommand command1 = new SqlCommand();
                command1.CommandText = "CREATE TABLE Staff(Id INT PRIMARY KEY IDENTITY, LOGIN NVARCHAR(32) NOT NULL, PASSWORD NVARCHAR(32) NOT NULL)";
                command1.Connection = connection;

                // Выполнение команды
                command1.ExecuteNonQuery();

                Console.WriteLine("Таблица создана");
                
            }

         
            
        }
    }
}
