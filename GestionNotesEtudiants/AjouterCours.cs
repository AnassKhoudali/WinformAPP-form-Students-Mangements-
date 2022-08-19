using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;
namespace GestionNotesEtudiants
{
    public partial class AjouterCours : Form
    {
        public AjouterCours()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AjouterCours_Load(object sender, EventArgs e)
        {

        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {

            //Creer s'il n'existe pas  le dossier qui va contenir les informations des cours dans C:\Cours.

            string lien = @$"C:\Cours";

            try
            {
                Dossier dossierCours = new Dossier("Cours");
                dossierCours.creerDossier(lien);
                //pour savoir le nombre cours qu'on a pour donner un numero de cours valide a notre nouveau cours.
                Cours.Increment = Dossier.fichierCount(lien);
                //Ajouter un nouvel objet cours.
                Cours cours = new Cours(codeCoursTxt.Text, titreCoursTxt.Text);
                //creer le fichier text contenant les informations du nouveau cours.
                //on choisi comme nom une combinaisons d'informations du cours pour faciliter la recherche ulterieurement.
                Fichier FichierCours = new Fichier($"_{cours.NumeroCours}_{cours.Code}_.txt");
                lien += @"\" + FichierCours.Nom;
                FichierCours.creerFichier(lien);
                File.WriteAllText(lien, cours.ToString());
                MessageBox.Show("Le nouveau cours a été ajouter avec succès !");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }
    }
}
