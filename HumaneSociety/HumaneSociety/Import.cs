using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Import
    {
        public static List<string[]> GetFromCSV(string file)
        {
            var dataToImport = File.ReadLines(file).Select(l => l.Split(',')).Select(x => x).ToList();
            return dataToImport;
        }

        public static void ImportData(string file)
        {
            try
            {
                HsdbLinqToSqlDataContext dbImportObj = new HsdbLinqToSqlDataContext();
                var importFile = GetFromCSV(file);
                foreach (var row in importFile)
                {
                    AddAnimalData animImport = new AddAnimalData();
                }
                Console.WriteLine("File successfully added.\n\n");
                Console.WriteLine("Press [ENTER] to continue....");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("An import error occurred, you must manually enter animals at this time");
                Console.ReadKey();
            }

        }
    }
}
