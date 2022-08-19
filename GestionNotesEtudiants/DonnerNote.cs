using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using System.IO;
using System.Linq;
namespace GestionNotesEtudiants
{
    public partial class DonnerNote : Form
    {
        public DonnerNote()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Boutton inscrire qui permet d'inscrire un etudiant a un cours.
        private void button1_Click(object sender, EventArgs e)
        {
             //On commence par trouver le fichier de l'etudiant.
            string lienEtudiant = Dossier.trouverFichier(@$"C:\Etudiants", numeroEtudiantTxt.Text);
            //si les informations sont incorrectes on affiche un message a l'utilisateur.
            if (lienEtudiant == "null")
            {
                MessageBox.Show("Il n'y a pas d'étudiant qui a ce numéro d'étudiant !");
                numeroEtudiantTxt.Focus();
            }
            else
            {
                bool FausseDonnees = true;
                //on ajoute les données qui figure dans le fichier dans une liste pour pouvoir trouver le bon endroit ou mettre la note. 
                List<string> informationsEtudiant = File.ReadAllLines(lienEtudiant).ToList();
                for (int i = 0; i < informationsEtudiant.Count; i++)
                {
                    if (informationsEtudiant[i] == $"NUMÉRO DE COURS : {numeroCoursTxt.Text}")
                    {
                        //Chaque cours est représenté textuellement sur 3 ligne(num cours, code cours, titre), donc on ajoute la note a line numCours+3
                        informationsEtudiant.Insert(i + 3, $"Note : {noteTxt.Text}");
                        File.WriteAllLines(lienEtudiant, informationsEtudiant);
                        FausseDonnees = false;
                    }

                }
                if (FausseDonnees == true)
                {
                    MessageBox.Show("Le numéro de cours entré n'est pas correcte, ou l'étudiant n'est pas inscrit au cours !");
                    numeroCoursTxt.Focus();
                }
                else
                {
                    MessageBox.Show("Note donnée avec succès !");
                }
            }
        }
    }
}
