using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumaneSocietyFormApp
{
    public partial class AnimalSearch : Form
    {
        List<Animal> animals = new List<Animal>();
        public AnimalSearch()
        {
            InitializeComponent();
            UpdateBinding();


        }

        private void UpdateBinding()
        {
            listBoxAnimalResult.DataSource = animals;
            listBoxAnimalResult.DisplayMember = "displayFoundInfo";
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            animals = db.GetAnimals(txtAnimalName.Text);

            UpdateBinding();
        }
    }
}
