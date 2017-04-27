using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Search : ISearch
    {
        private string adpFName;
        private string adpLName;
        private string animalName;

        public void SearchAdoperByName()
        {
            DbConnect db = new DbConnect();

            Adopter adopter = new Adopter();

            Console.WriteLine("Enter Adopter's First Name");
            adpFName = Console.ReadLine();
            Console.WriteLine("Enter Adopter's Last Name");
            adpLName = Console.ReadLine();
            //var adopterResult = from a in adopter
            //                    where a.FirstName == adpFName
            //                    where a.LastName == adpLName
            //                    select a;

            //Console.WriteLine(adopterResult);
            //Console.ReadKey();
        }

        public void SearchASpecificAnimal()
        {
            DbConnect db = new DbConnect();

            Animal animal = new Animal();

            Console.WriteLine("Enter the animal name of the animal you are looking for");
            animalName = Console.ReadLine();

            //var animalResult = animal.Where(a => a.Name == animalName);
            //Console.WriteLine(animalResult);

            SqlCommand command = new SqlCommand($"SELECT * FROM Animal"/* WHERE Name = {animalName}"*/);
            SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("ID: {0} \nName: {1} \nGender: {2} \nRoom: {3} \nFood: {4} \nAnimal Type: {5}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    Console.WriteLine("*******************************");
                }
                reader.Close();
            
            Console.ReadKey();
        }

        public void SearchForPetsToAdopt()
        {
            DbConnect db = new DbConnect();
            SqlCommand command = new SqlCommand($"SELECT * FROM Animal");
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    // get the results of each column
                    
                    // print out the results
                    Console.WriteLine("ID: {0} \nName: {1} \nGender: {2} \nRoom: {3} \nFood: {4} \nAnimal Type: {5}",
                        reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                    Console.WriteLine("*******************************");
                    Console.WriteLine();
                }
            } finally {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            

            // Animal animal = new Animal();



            Console.WriteLine("Enter choice for Animal Type:\nDog\nCat\nRabbit\nBird\nOther");
            Console.ReadLine();

        }

    }
}
