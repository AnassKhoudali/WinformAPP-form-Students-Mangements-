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
    public partial class InscrireEtudiant : Form
    {
        public InscrireEtudiant()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Acceuil acceuil = new Acceuil();
            acceuil.Show();
            this.Hide();

        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            
           try
            {
                string lienCours = Dossier.trouverFichier(@"C:\Cours", numeroCoursTxt.Text);
                if (lienCours.Equals("null"))
                {
                    MessageBox.Show("les informations entrées du cours sont incorrectes !");
                    numeroCoursTxt.Text = "";
                    numeroCoursTxt.Focus();
                }
                else
                {
                    string lienEtudiant = Dossier.trouverFichier(@"C:\Etudiants", numeroEtudiantTxt.Text);
                    if (lienEtudiant.Equals("null"))
                    {
                        MessageBox.Show("les informations entrées de l'étudiant sont incorrectes !");
                        numeroEtudiantTxt.Text = "";
                        numeroEtudiantTxt.Focus();
                    }
                    else
                    {
                        
                        List<string> CoursInfos = File.ReadAllLines(lienCours).ToList();
                        List<string> CoursInfos1 = new List<string>();
                        File.AppendAllLines(lienEtudiant, CoursInfos);
                        MessageBox.Show("L'étudiant a été au cours inscrit avec réeussite !");
                    }
                   
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
