using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class AddAnimalData
    {
        public AddAnimalData()
        {
            Animal animal = new Animal();

            Console.WriteLine("\nEnter New animal info according to options.");
            Console.WriteLine("1. Room Placement: ");
            animal.Room = Console.ReadLine().ToLower();
            Console.WriteLine("2. Animal's Name: ");
            animal.Name = Console.ReadLine().ToLower();
            Console.WriteLine("3. Animal Type: ");
            animal.AnimalType = Console.ReadLine().ToLower();
            Console.WriteLine("4. Gender: ");
            animal.Gender = Console.ReadLine().ToLower();
            Console.WriteLine("5. Food: ");
            animal.Food = Console.ReadLine().ToLower();
            Console.WriteLine("6. Shots: ");
            animal.Shot = Console.ReadLine().ToLower();
            Console.Clear();
            

        }


    }
}
