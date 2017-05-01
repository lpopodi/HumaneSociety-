using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class EmployeeMenu
    {

        string empMenuInput;

        public EmployeeMenu()
        {
            EmployeeMainMenu();
        }
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
                    AddAnimalData newAnimal = new AddAnimalData();
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
                    Search empSearch = new Search();
                    empSearch.SearchASpecificAnimal();
                    break;
                default:
                    Console.WriteLine("Your input was not recognized, press any key to return to the main menu");
                    Console.ReadKey();
                    EmployeeMainMenu();
                    break;
            }
        } //End Employee Main Menu
    } //end Employee Menu
} // end namespace
