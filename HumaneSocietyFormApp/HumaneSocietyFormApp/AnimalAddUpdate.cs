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
    public partial class AnimalAddUpdate : Form
    {
        public AnimalAddUpdate()
        {
            InitializeComponent();
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GetAnimals(txtAnimalName.Text);
        }

        private void btnInsertAnimal_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertAnimal(txtAnimalName.Text, txtAnimalGender.Text, txtRoom.Text, txtFood.Text, txtAnimalType.Text, txtShots.Text);
            txtAnimalName.Text = "";
            txtAnimalGender.Text = "";
            txtRoom.Text = "";
            txtFood.Text = "";
            txtAnimalType.Text = "";
            txtShots.Text = "";
        }

        //private void btnUpdateAnimal_Click(object sender, EventArgs e)
        //{
        //    DataAccess db = new DataAccess();
        //    db.UpdateAnimal( txtAnimalName.Text, txtAnimalGender.Text, txtRoom.Text, txtFood.Text, txtAnimalType.Text, txtShots.Text);
        //}

        //private void btnDeleteAnimal_Click(object sender, EventArgs e)
        //{
        //    DataAccess db = new DataAccess();
        //    db.DeleteAnimal(txtAnimalId.Text, txtAnimalName.Text, txtAnimalGender.Text, txtRoom.Text, txtFood.Text, txtAnimalType.Text, txtShots.Text);
        //}
    }
}
