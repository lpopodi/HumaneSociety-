using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class MainMenu
    {
        string visitorChoice;

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
                    AdopterMenu adopterMenu = new AdopterMenu(); 
                    break;
                case "E":
                case "EMPLOYEE":
                    Console.WriteLine("You have selected Employee, press any key to continue");
                    Console.ReadKey();
                    EmployeeMenu employeeMenu = new EmployeeMenu();
                    break;
                default:
                    Console.WriteLine("Your input was not regognized, press any key to go back to the Main Menu");
                    Console.ReadKey();
                    MenuVisitorSelection();
                    break;
            }
        } 
    }
}
