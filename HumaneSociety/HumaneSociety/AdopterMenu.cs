using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdopterMenu
    {
        string adoptMenuInput;

        public AdopterMenu()
        {
            AdopteeMainMenu();
        } //close Adoptee Constructor

        public void AdopteeMainMenu()
        {
            Console.WriteLine("Humane Society Adoptee Portal");
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
                    Register register = new Register();
                    break;
                case "2":
                case "LOG IN":
                    Console.WriteLine("You have chosen to Log In, I'm sorry we have not added that capability yet");
                    Console.ReadKey();
                    break;
                case "3":
                case "SEARCH":
                    Console.WriteLine("You have selected to search an animal, press any key to continue");
                    Console.ReadKey();
                    Search adpSearch = new Search();
                    adpSearch.SearchForPetsToAdopt();
                    break;
                default:
                    Console.WriteLine("Your input was not recognized, press any key to return to the main menu");
                    Console.ReadKey();
                    AdopteeMainMenu();
                    break;
            } //end case switch
        } //end AdopteeMainMenu
        } // end Adoptee menu
    } // end namespace
