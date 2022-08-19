using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace GestionNotesEtudiants
{
    public partial class ListeEtudiants : Form
    {


        /// <summary>
        /// Cette attribut va permetre de stocker le chemin entre par l'utilisateur pour l'utiliser ulterieurment dans le formulaire ajouter etudiant.
        /// </summary>
        public string CurrentPath { get; set; }
        public ListeEtudiants()
        {
            InitializeComponent();
        }

     
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {
            //Pour ouvrir la fenetre de navigation des dossiers.
            FolderBrowserDialog folderbowser = new FolderBrowserDialog();

            if (folderbowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string chemin = folderbowser.SelectedPath;
                lienTxt.Text = chemin;
            }
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                String nomFichier = nomTxt.Text;
                StreamWriter sw = new StreamWriter(lienTxt.Text + "/" + nomTxt.Text + ".txt");
                MessageBox.Show("Votre nouvelle liste d'erudiants a été crée");
                this.CurrentPath = lienTxt.Text + "/" + nomTxt.Text + ".txt";
            }

            catch
            {
                MessageBox.Show("le chemein entré est invalide ! Veuillez réessayer");
            }

            Console.Read();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
                Acceuil Check = new Acceuil();
                Check.Show();
                Hide();
            
        }
    }
}
