using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class DbConnect
    {
        
        SqlConnection connection;
        public DbConnect()
        {
            OpenDatabaseConnection();
        }

        public void OpenDatabaseConnection()
        {
            connection = new SqlConnection("Server=Lisa-Laptop;Database=HumaneSocietyDB;Integrated Security=true");
            try
            {
                connection.Open();
                Console.WriteLine("Connection Successful");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DatabaseReader()
        {

        }

        public void DatabaseSaver()
        {


        }

    }
}
