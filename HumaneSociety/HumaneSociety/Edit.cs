using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Edit : IEdit
    {

        public void EditAnimalType(string animToEdit)
        {
            using (HsdbLinqToSqlDataContext editTypeObj = new HsdbLinqToSqlDataContext())
            {
                Animal animal = new Animal();
                
                if (animal.AnimalType == animToEdit)
                {
                    Console.WriteLine("Please enter Animal Type Value to be updated.");
                    animal.AnimalType = Console.ReadLine();
                }

                editTypeObj.SubmitChanges();
            }
        }

        public void EditFood(string animToEdit)
        {
            using (HsdbLinqToSqlDataContext editFoodObj = new HsdbLinqToSqlDataContext())
            {
                Animal animal = new Animal();

                if (animal.Food == animToEdit)
                {
                    Console.WriteLine("Please enter Animal Type Value to be updated.");
                    animal.Food = Console.ReadLine();
                }

                editFoodObj.SubmitChanges();
            }
        }

        public void EditShot(string animToEdit)
        {
            using (HsdbLinqToSqlDataContext editShotObj = new HsdbLinqToSqlDataContext())
            {
                Animal animal = new Animal();

                if (animal.Shot == animToEdit)
                {
                    Console.WriteLine("Please enter Animal Type Value to be updated.");
                    animal.Shot = Console.ReadLine();
                }

                editShotObj.SubmitChanges();
            }
        }
    }
}
