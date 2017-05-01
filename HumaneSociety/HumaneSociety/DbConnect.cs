using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HumaneSociety
{
    public class DbConnect
    {

        //public static string ConVal(string name)
        //{
        //    return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        //}

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



    }

    //public class DatabaseSaver
    //{
    //    SqlConnection connection;
    //    public DatabaseSaver()
    //    {
    //        connection = new SqlConnection("Server=MICHAEL-PC;Database=RPSLS;Integrated Security=true");
    //    }
    //    public void Save(string winnerName, string loserName, int winnerScore, int loserScore)
    //    {
    //        try
    //        {
    //            connection.Open();
    //            SqlCommand command = new SqlCommand($"INSERT INTO Scores VALUES ('{animalId}', '{animalName}', '{animalGender}', '{animalRoom}','{animalFood}', '{animalType}')", connection);
    //            command.ExecuteNonQuery();
    //            connection.Close();
    //            Console.WriteLine("New Animal has been added");
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
