using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsDbProject
{
    public class MainMenu
    {
        string visitorChoice;
        private string adoptMenuInput;
        private string empMenuInput;

        public MainMenu()
        {
            Console.WriteLine("Welcome to the Humane Society Application");
            MenuVisitorSelection();
        }

        public void MenuVisitorSelection()
        {
            Console.WriteLine("Please enter A for Adoptee, or E for Employee");
            visitorChoice = Console.ReadLine().ToUpper();
            switch (visitorChoice)
            {
                case "A":
                case "ADOPTER":
                    Console.WriteLine("You have selected Adopter, press any key to continue");
                    Console.ReadKey();
                    AdopterMainMenu();
                    break;
                case "E":
                case "EMPLOYEE":
                    Console.WriteLine("You have selected Employee, press any key to continue");
                    Console.ReadKey();
                    EmployeeMainMenu();
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back to the Main Menu");
                    Console.ReadKey();
                    MenuVisitorSelection();
                    break;
            }
        }

        public void AdopterMainMenu()
        {
            Console.WriteLine("Humane Society Adopter Portal");
            Console.WriteLine("Here you can Register, Log In, or search for animals to bring in to your family");
            Console.WriteLine("Your Options are as follows:");
            Console.WriteLine("1\tor\tREGISTER\n2\tor\tLOG IN\n3\tor\tSEARCH");
            adoptMenuInput = Console.ReadLine().ToUpper();
            switch (adoptMenuInput)
            {
                case "1":
                case "REGISTER":
                    Console.WriteLine("You have chosen to register for an account .. Thank You!\nPress any key to continue");
                    Console.ReadKey();
                    break;
                case "2":
                case "LOG IN":
                    Console.WriteLine("You have chosen to Log In, press any key to continue to login");
                    Console.ReadKey();
                    break;
                case "3":
                case "SEARCH":
                    Console.WriteLine("You have selected to search an animal, press any key to continue");
                    Console.ReadKey();
                    Search aSearch = new Search();
                    aSearch.SearchPets();
                    break;
                default:
                    Console.WriteLine("Your input was not recognized, press any key to return to the main menu");
                    Console.ReadKey();
                    AdopterMainMenu();
                    break;
            } //end case switch
        } //end AdopterMainMenu

        public void EmployeeMainMenu()
        {
            Console.WriteLine("Humane Society Employee Portal");
            Console.WriteLine("Here you can add a single animal, import animals from a csv file,\n or search an animal to view info, manage details, and complete adoption");
            Console.WriteLine("Your Options are as follows:");
            Console.WriteLine("1\tor\tADD\n2\tor\tIMPORT\n3\tor\tSEARCH");
            empMenuInput = Console.ReadLine().ToUpper();
            switch (empMenuInput)
            {
                case "1":
                case "ADD":
                    Console.WriteLine("You have selected to add a single animal, press any key to continue");
                    Console.ReadKey();
                    AddAnimal addAnimal = new AddAnimal();
                    break;
                case "2":
                case "IMPORT":
                    Console.WriteLine("You have selected to import from a csv, press any key to continue");
                    Console.ReadKey();
                    break;
                case "3":
                case "SEARCH":
                    Console.WriteLine("You have selected to search an animal, press any key to continue");
                    Console.ReadKey();
                    Search eSearch = new Search();
                    eSearch.SearchAnimal();
                    break;
                default:
                    Console.WriteLine("Your input was not recognized, press any key to return to the main menu");
                    Console.ReadKey();
                    EmployeeMainMenu();
                    break;
            }
        } //End Employee Main Menu

    }
}