using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Register
    {
        public Register()
        {
            HsdbLinqToSqlDataContext dbAdopterObj = new HsdbLinqToSqlDataContext();

            Adopter adopter = new Adopter();

            Console.WriteLine("\nFill out user registration information below ..");
            Console.WriteLine("Enter First Name:");
            adopter.P_FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            adopter.P_LastName = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            adopter.P_Address = Console.ReadLine();
            Console.WriteLine("Enter City:");
            adopter.P_City = Console.ReadLine();
            Console.WriteLine("Enter State:");
            adopter.P_State = Console.ReadLine();
            Console.WriteLine("Enter Zip:");
            adopter.P_Zip = Console.ReadLine();
            Console.WriteLine("Phone:");
            adopter.P_Phone = Console.ReadLine();

            dbAdopterObj.Adopters.InsertOnSubmit(adopter);
            try
            {
                dbAdopterObj.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("An error occurred, sorry for the inconvenience");
                dbAdopterObj.SubmitChanges();
            }
        }
    }
}
