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

    public partial class ajouterNouvelEtudiant : Form
    {



        public ajouterNouvelEtudiant()
        {
            InitializeComponent();
        }

        //Ajouter l'etudiant dans un fichier text sur l'ordinateur contenu dans C:\Users\Public\Documents\Etudiants.
        private void button1_Click(object sender, EventArgs e)
        {
            //creer le fichier text de l'etudiant dans le dossier C:\Users\Public\Documents.
            string lien = @$"C:\Etudiants";

            try
            {
                Dossier dossierEtudiants = new Dossier("Etudiants");
                dossierEtudiants.creerDossier(lien);
                //savoir le nombre d'etudiants qu'on a dans le dossier pour donner un numero adequat a notre nouvel etudiant.
                Etudiant.Increment = Dossier.fichierCount(lien);
                //Ajouter un nouvel objet etudiant.
                Etudiant etudiant = new Etudiant(textBox3.Text, prenomTxt.Text);
                //creer le fichier text contenant les informations du nouvel etudiants.
                //on choisi comme nom une combinaisons d'informations de l'etudiant pour faciliter la recherche ulterieurement.
                Fichier FichierEtudiant = new Fichier($"_{etudiant.NumeroEtudiant}_{etudiant.Nom}_{etudiant.Prenom}_.txt");
                lien += @"\" + FichierEtudiant.Nom;
                FichierEtudiant.creerFichier(lien);
                File.WriteAllText(lien, etudiant.ToString());
                MessageBox.Show("l'étudiant a été ajouté avec succes");
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ajouterNouvelEtudiant_Load(object sender, EventArgs e)
        {


        }



        //retour a la page d'acceuil
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();

        }
    }
}
