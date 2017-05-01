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
        SqlConnection connection;
        private string adpFName;
        private string adpLName;
        private string animalName;
        private string searchCriteria;
        private string criteriaInput;
        private string typeChoice;

        public void SearchAdoperByName()
        {
            DbConnect db = new DbConnect();

            Adopter adopter = new Adopter();

            Console.WriteLine("Enter Adopter's First Name");
            adpFName = Console.ReadLine();
            Console.WriteLine("Enter Adopter's Last Name");
            adpLName = Console.ReadLine();
            HsdbLinqToSqlDataContext dbAdopter = new HsdbLinqToSqlDataContext();
            var adopterResult = dbAdopter.Adopters.Where(f => f.FirstName == adpFName).Where(l => l.LastName == adpLName).Select(a => a).ToList();
            if (adopterResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var person in adopterResult)
                {
                    Console.WriteLine("  ID: " + person.PersonID);
                    Console.WriteLine("  First Name: " + person.FirstName);
                    Console.WriteLine("  Last Name: " + person.LastName);
                    Console.WriteLine("  Address: " + person.Address);
                    Console.WriteLine("  City: " + person.City);
                    Console.WriteLine("  State: " + person.State);
                    Console.WriteLine("  Zip: " + person.Zip);
                    Console.WriteLine("  Phone: " + person.Phone);
                }
            }
            else
            {
                Console.WriteLine("! No Matches Found. !\n\n");
            }
            Console.WriteLine("Press any key to continue....");

            Console.ReadKey();
        }

        public void SearchASpecificAnimal()
        {
            Console.WriteLine("Enter the animal name of the animal you are looking for");
            animalName = Console.ReadLine();

            //DbConnect db = new DbConnect();
            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(n => n.Name == animalName).Select(s => s).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.animalType);
                    Console.WriteLine("  Gender: " + match.Gender);
                    Console.WriteLine("  Food: " + match.Food);
                    Console.WriteLine("  Shots: " + match.Shot);
                    Console.WriteLine("  Price: " + match.Price);
                }
            }
            else
            {
                Console.WriteLine("! No Matches Found. !\n\n");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void SearchForPetsToAdopt()
        {
            Console.WriteLine("How would you like to search for your new pet?");
            Console.WriteLine("Choose from the following options:\n-->1. Animal Type\n2. Gender\n3. Both\n");
            searchCriteria = Console.ReadLine().ToUpper();
            switch (searchCriteria)
            {
                case "1":
                case "ANIMAL TYPE":
                    Console.WriteLine("You have selected Animal Type, press any key to continue");
                    Console.ReadKey();
                    GetTypeSelection();
                    break;
                case "2":
                case "GENDER":
                    Console.WriteLine("You have selected Gender, press any key to continue");
                    Console.ReadKey();
                    SearchByGender();
                    break;
                case "3":
                case "BOTH":
                    Console.WriteLine("You have selected Both, press any key to continue");
                    Console.ReadKey();
                    SearchByBoth()
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back and try again");
                    Console.ReadKey();
                    SearchForPetsToAdopt();
                    break;
            }
        }

        public void GetTypeSelection()
        {
            Console.WriteLine("Select animal type for search");
            Console.WriteLine("Choose from the following options:\n-->1. Dog\n2. Cat\n3. Rabbit\n4. Bird\n5. Other Small Animals");
            criteriaInput = Console.ReadLine().ToUpper();
            switch (criteriaInput)
            {
                case "1":
                case "DOG":
                    Console.WriteLine("You have selected Animal Type, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "dog";
                    SearchByType();
                    break;
                case "2":
                case "CAT":
                    Console.WriteLine("You have selected Gender, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "cat";
                    SearchByType();
                    break;
                case "3":
                case "RABBIT":
                    Console.WriteLine("You have selected Both, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "rabbit";
                    SearchByType()
                    break;
                case "4":
                case "BIRD":
                    Console.WriteLine("You have selected Gender, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "bird";
                    SearchByType();
                    break;
                case "5":
                case "OTHER":
                case "OTHER SMALL ANIMALS":
                    Console.WriteLine("You have selected Both, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "other";
                    SearchByType()
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back and try again");
                    Console.ReadKey();
                    GenerateTypeSelection();
                    break;
            }

        }

        public void SearchByType()
        {    
            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(n => n.Name == animalName).Select(s => s).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.animalType);
                    Console.WriteLine("  Gender: " + match.Gender);
                    Console.WriteLine("  Food: " + match.Food);
                    Console.WriteLine("  Shots: " + match.Shot);
                    Console.WriteLine("  Price: " + match.Price);
                }
            }
            else
            {
                Console.WriteLine("! No Matches Found. !\n\n");
            }
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
        }

        public void SearchByGender()
        {

        }

        public void SearchByBoth()
        {

        }

    }
}
