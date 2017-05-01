using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AdoptAnimal
    {
        private bool paymentReceived;
        private string paymentInput;

        public AdoptAnimal(string animToEdit)
        {
            CollectPayment(animToEdit);
            DeleteAnimalFromTable(animToEdit);
        }

        private void DeleteAnimalFromTable(string animToEdit)
        {
            HsdbLinqToSqlDataContext removeAnimObj = new HsdbLinqToSqlDataContext();
            List<Animal> removeFromGroup = (from animal in removeAnimObj.Animals
                                                 where (animal.Room == animToEdit)
                                                 select animal).ToList();


            removeAnimObj.Animals.DeleteAllOnSubmit(removeFromGroup);
            removeAnimObj.SubmitChanges();
            Console.WriteLine("This record has been deleted, Press any key to return to the Main Menu");
            Console.ReadKey();
            MainMenu mainMenu = new MainMenu();
        }

        private void CollectPayment(string animToEdit)
        {
            HsdbLinqToSqlDataContext payAnimBalance = new HsdbLinqToSqlDataContext();
            var animalPrice = payAnimBalance.Animals.Where(r => r.Room == animToEdit).Select(p => p).ToList();
            if (animalPrice != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var adoptee in animalPrice)
                {
                    Console.WriteLine("  Price: " + adoptee.Price);
                    CollectMoney();
                }
            }
            else
            {
                Console.WriteLine("! No Matches Found. !\n");
            }

        }

        private void CollectMoney()
        {
            Console.WriteLine("Collect Money from adopter ... \nDid you collect payment?  Yes or No");
            paymentInput = Console.ReadLine().ToUpper();
            switch(paymentInput)
            {
                case "YES":
                    paymentReceived = true;
                    break;
                case "NO":
                    paymentReceived = false;
                    break;
                default:
                    Console.WriteLine("your input was not recognized, please enter only yes or no\nEnter any key to go back to Collecting Payment");
                    Console.ReadKey();
                    CollectMoney();
                    break;
            }
            if (paymentReceived == false)
            {
                Console.WriteLine("! You must get payment before proceeding to the next steps !\n");
                CollectMoney();
            }
            
        }
    }
}
