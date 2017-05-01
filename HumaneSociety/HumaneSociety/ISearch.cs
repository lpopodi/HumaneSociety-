using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public interface ISearch
    {
        void SearchForPetsToAdopt();

        void SearchASpecificAnimal();

        void SearchAdoperByName();

        void SearchByGender();

        void SearchByType();

        void SearchByBoth();
    }
}
