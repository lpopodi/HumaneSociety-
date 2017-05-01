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
        private string typeInput;
        private string typeChoice;
        private string genderChoice;
        private string genderInput;
        private string animToEdit;

        public void SearchAdoperByName()
        {
            DbConnect db = new DbConnect();

            Adopter adopter = new Adopter();

            Console.WriteLine("Enter Adopter's First Name");
            adpFName = Console.ReadLine();
            Console.WriteLine("Enter Adopter's Last Name");
            adpLName = Console.ReadLine();
            HsdbLinqToSqlDataContext dbAdopter = new HsdbLinqToSqlDataContext();
            var adopterResult = dbAdopter.Adopters.Where(f => f.P_FirstName == adpFName).Where(l => l.P_LastName == adpLName).Select(a => a).ToList();
            if (adopterResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var person in adopterResult)
                {
                    Console.WriteLine("  ID: " + person.PersonID);
                    Console.WriteLine("  First Name: " + person.P_FirstName);
                    Console.WriteLine("  Last Name: " + person.P_LastName);
                    Console.WriteLine("  Address: " + person.P_Address);
                    Console.WriteLine("  City: " + person.P_City);
                    Console.WriteLine("  State: " + person.P_State);
                    Console.WriteLine("  Zip: " + person.P_Zip);
                    Console.WriteLine("  Phone: " + person.P_Phone);
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

            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(n => n.Name == animalName).Select(s => s).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.AnimalType);
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

            GetOptionToEdit();
        }

        public void GetOptionToEdit()
        {
            Console.WriteLine("If you want to make any edits to an existing animal, please enter the animal's room number to continue to editing options");
            animToEdit = Console.ReadLine().ToLower();
            Console.WriteLine("Choose from the following options:\n-->1. Edit Animal Type\n-->2. Edit Food\n-->3. Edit Shots\n-->4. Adoption -->5. Exit to Main Menu");
            searchCriteria = Console.ReadLine().ToUpper();
            switch (searchCriteria)
            {
                case "1":
                case "ANIMAL TYPE":
                    Console.WriteLine("You have selected to Edit Animal Type, press any key to continue");
                    Console.ReadKey();
                    Edit typeEdit = new Edit();
                    typeEdit.EditAnimalType(animToEdit);
                    break;
                case "2":
                case "FOOD":
                    Console.WriteLine("You have selected to Edit Food, press any key to continue");
                    Console.ReadKey();
                    Edit foodEdit = new Edit();
                    foodEdit.EditFood(animToEdit);
                    break;
                case "3":
                case "SHOTS":
                    Console.WriteLine("You have selected to Edit Shots, press any key to continue");
                    Console.ReadKey();
                    Edit shotEdit = new Edit();
                    shotEdit.EditFood(animToEdit);
                    break;
                case "4":
                case "ADOPTION":
                    Console.WriteLine("You have selected to complete adoption for this animal, press any key to continue");
                    Console.ReadKey();
                    AdoptAnimal adoption = new AdoptAnimal(animToEdit);
                    break;
                case "5":
                case "EXIT":
                    Console.WriteLine("You have selected to Edit Shots, press any key to continue");
                    Console.ReadKey();
                    MainMenu mainMenu = new MainMenu();
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back and try again");
                    Console.ReadKey();
                    GetOptionToEdit();
                    break;
            }
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
                    SearchByType();
                    break;
                case "2":
                case "GENDER":
                    Console.WriteLine("You have selected Gender, press any key to continue");
                    Console.ReadKey();
                    GetGenderSelection();
                    SearchByGender();
                    break;
                case "3":
                case "BOTH":
                    Console.WriteLine("You have selected Both, press any key to continue");
                    Console.ReadKey();
                    GetTypeSelection();
                    GetGenderSelection();
                    SearchByBoth();
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
            typeInput = Console.ReadLine().ToUpper();
            switch (typeInput)
            {
                case "1":
                case "DOG":
                    Console.WriteLine("You have selected Dog, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "dog";
                    break;
                case "2":
                case "CAT":
                    Console.WriteLine("You have selected Cat, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "cat";
                    break;
                case "3":
                case "RABBIT":
                    Console.WriteLine("You have selected Rabbit, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "rabbit";
                    break;
                case "4":
                case "BIRD":
                    Console.WriteLine("You have selected Bird, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "bird";
                    break;
                case "5":
                case "OTHER":
                case "OTHER SMALL ANIMALS":
                    Console.WriteLine("You have selected Other, press any key to continue");
                    Console.ReadKey();
                    typeChoice = "other";
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back and try again");
                    Console.ReadKey();
                    GetTypeSelection();
                    break;
            }

        }

        public void GetGenderSelection()
        {
            Console.WriteLine("Select animal Gender");
            Console.WriteLine("Choose from the following options:\n-->1. Male\n-->2. Female");
            genderInput = Console.ReadLine().ToUpper();
            switch (genderInput)
            {
                case "1":
                case "MALE":
                    Console.WriteLine("You have selected Male, press any key to continue");
                    Console.ReadKey();
                    genderChoice = "male";
                    break;
                case "2":
                case "FEMALE":
                    Console.WriteLine("You have selected Female, press any key to continue");
                    Console.ReadKey();
                    genderChoice = "female";
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back and try again");
                    Console.ReadKey();
                    GetGenderSelection();
                    break;
            }

        }

        public void SearchByType()
        {    
            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(t => t.AnimalType == typeChoice).Select(anim => anim).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.AnimalType);
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
            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(g => g.Gender == genderChoice).Select(anim => anim).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.AnimalType);
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

        public void SearchByBoth()
        {
            HsdbLinqToSqlDataContext dbAnimSearch = new HsdbLinqToSqlDataContext();
            var animalResult = dbAnimSearch.Animals.Where(t => t.AnimalType == typeChoice).Where(g => g.Gender == genderChoice).Select(anim => anim).ToList();
            if (animalResult != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in animalResult)
                {
                    Console.WriteLine("  Room: " + match.Room);
                    Console.WriteLine("  Name: " + match.Name);
                    Console.WriteLine("  Animal Type: " + match.AnimalType);
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

    }
}
