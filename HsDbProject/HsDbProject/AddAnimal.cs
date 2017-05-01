using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsDbProject
{
    public class AddAnimal
    {
        private SqlConnection connection;

        public int animalID { get; set; }
        public string name { get; set; }
        public string animalType { get; set; }
        public string gender { get; set; }
        public string room { get; set; }
        public string food { get; set; }
        public string shot { get; set; }

        public AddAnimal()
        {
            connection = new SqlConnection("Server=LISA-LAPTOP;Database=HsDb;Integrated Security=true");

             public void GetAnimalValues()
        {
            //Console.WriteLine("Please enter an animal ID:");
            animalID = 5;
            //Console.WriteLine("Please enter the animal's name:");
            name = "Cotton";
            animalType = "Rabbit";
            gender = "Male";
            room = "C3";
            food = "carrots";
            shot = "no";

        }

        public void Save(int animalID, string name, string animalType, string gender, string room, string food, string shot)
        {
            try
            {
                connection.Open();
                Console.WriteLine("............Connected");
                SqlCommand command = new SqlCommand($"INSERT INTO Animal VALUES ('{animalID}', '{name}', '{animalType}', '{gender}', '{room}', '{food}', '{shot}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("New Animal Added");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }

    }
}
