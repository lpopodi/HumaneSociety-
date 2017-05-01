using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;


namespace HumaneSocietyFormApp
{
    public class DataAccess
    {  

        public List<Animal> GetAnimals(string animalName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConVal("HumaneSocietyDB")))
            {
                var output = connection.Query<Animal>($"select * from Animal where AnimalName = '{animalName}'").ToList();
                //var output = connection.Query<Animal>("dbo.Animal_GetAnimalByName @AnimalName", new { AnimalName = animalName }).ToList();
                // above using stored procedure
                return output;
            }
        }


        public void InsertAnimal( string animalName, string animalGender, string room, string food, string animalType, string shots)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbConnect.ConVal("HumaneSocietyDB")))
            {
                //Animal newAnimal = new HumaneSocietyFormApp.Animal { AnimalID = animalID, AnimalName = animalName, AnimalGender = animalGender, Room = room, Food = food, AnimalType = animalType, Shots = shots };
                List<Animal> animals = new List<Animal>();
                animals.Add( new Animal { AnimalName = animalName, AnimalGender = animalGender, Room = room, Food = food, AnimalType = animalType, Shots = shots } );

                connection.Execute("dbo.Animal_Insert @AnimalName, @AnimalGender, @Room, @Food, @AnimalType, @Shots", animals);
            }
        }
    }
}
