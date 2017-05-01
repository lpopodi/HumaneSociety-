using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyFormApp
{
    public partial class Animal
    {
        public int animalID { get; set; }
        public string animalName { get; set; }
        public string animalGender { get; set; }
        public string room { get; set; }
        public string food { get; set; }
        public string animalType { get; set; }
        public string shots { get; set; }

        public string displayFoundInfo
        {
            get
            {
                return $"{ animalID } { animalName } ({ animalType })";
            }
        }

        public string AnimalName { get; internal set; }
        public string AnimalGender { get; internal set; }
    }
}
