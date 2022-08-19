using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionNotesEtudiants
{
    public partial class Acceuil : Form
    {
        public Acceuil()
        {
            InitializeComponent();
        }

      

        private void btnNouvelleListeEtudiants_Click(object sender, EventArgs e)
        {
            ListeEtudiants liste = new ListeEtudiants();
            liste.Show();
            this.Hide();
        }

        private void btnNouvelleListeCours_Click(object sender, EventArgs e)
        {
            ListeCours liste = new ListeCours();
            liste.Show();
            this.Hide();
        }

        private void btnAjouterEtudiant_Click(object sender, EventArgs e)
        {
            ajouterNouvelEtudiant liste = new ajouterNouvelEtudiant();
            liste.Show();
            this.Hide();
        }


        private void btnAjouterCours_Click_1(object sender, EventArgs e)
        {
            AjouterCours liste = new AjouterCours();
            liste.Show();
            this.Hide();
        }

        private void btnInscrireEtudiantCours_Click_1(object sender, EventArgs e)
        {
            InscrireEtudiant inscrire = new InscrireEtudiant();
            inscrire.Show();
            this.Hide();
        }

        private void btnDonnerNote_Click_1(object sender, EventArgs e)
        {
            DonnerNote note = new DonnerNote();
            note.Show();
            this.Hide();
        }

        private void btnVoirResultatsEtudiant_Click_1(object sender, EventArgs e)
        {
            AfficherResultatsEtudiant resultats = new AfficherResultatsEtudiant();
            resultats.Show();
            this.Hide();
        }
    }

}
