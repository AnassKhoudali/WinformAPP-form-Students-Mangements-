using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ClassLibrary;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
namespace GestionNotesEtudiants

{
    public partial class AfficherResultatsEtudiant : Form
    {
        public AfficherResultatsEtudiant()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            string cheminDossierEtudiants = @"C:\Etudiants";
            string lienEtudiant = Dossier.trouverFichier(cheminDossierEtudiants, numeroEtudiantTxt.Text);
            
            if (lienEtudiant == "null")
            {
                MessageBox.Show("les données entrées sont inccorectes !");
            }
            else
            {
                
                List < string > donnerEtudiants = File.ReadAllLines(lienEtudiant).ToList();
                List<string> htmlFile = File.ReadAllLines(@"..\..\..\..\resultats\index.html").ToList();
                Fichier.mergeIfo(donnerEtudiants, htmlFile);
                string nomFichier = Path.GetFileNameWithoutExtension(lienEtudiant);
                string CheminFichierhtmlEtudiant = $@"..\..\..\..\resultats\{nomFichier}.html";
                string cheminAbsolutFichier = Path.GetFullPath(CheminFichierhtmlEtudiant);
                File.WriteAllLines(cheminAbsolutFichier, htmlFile);
                MessageBox.Show(cheminAbsolutFichier);
                try
                {
                    //ouvrir le releve de note sur edge.
                    Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe", cheminAbsolutFichier);

                }
                catch
                {
                    //ouvrir le releve de note sur notepad et chrome s'il ya une erreur de chemin avec edge.
                    Process.Start("notepad.exe", lienEtudiant);
                    Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", CheminFichierhtmlEtudiant);

                }
            }

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numeroEtudiantTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
