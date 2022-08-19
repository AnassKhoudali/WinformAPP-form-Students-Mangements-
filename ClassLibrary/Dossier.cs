using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ClassLibrary
{
    //cette class contient tous les methodes relatives a la creation de dossiers.
    public class Dossier
    {
        public string Nom { get; set; }
        public Dossier(string nom)
        {
            this.Nom = nom;
        }

        public void creerDossier(string lien)
        {
            // si le dossier n'esxiste pas on le cree.
            if (!Directory.Exists(lien))
            {
                Directory.CreateDirectory(lien);
            }
        }
        /// <summary>
        /// cette fonction servira pour savoir le nombre de fichiers qui exist dans un dossier.
        /// Elle sevira par la suite pour savoir le nombre d'etudiants et par consequent le numero qui sera donner au nouvel etudiant et la meme chose pour les cours.
        /// </summary>
        public static int fichierCount(string LienDuDossier)
        {

            System.IO.DirectoryInfo dossier = new System.IO.DirectoryInfo(LienDuDossier);
            int count = dossier.GetFiles().Length;
            return count;
        }

        //trouver un fichier avec s
        public static string trouverFichier(String LienDuDossier, String nomPartiel)
        {
            DirectoryInfo infoDossier = new DirectoryInfo(LienDuDossier);
            //pour nos fichier on a mis le separateur _ pour les nom ce qui va faciliter la recherche.
            FileInfo[] fichiers = infoDossier.GetFiles("*" + "_" + nomPartiel + "_" + "*.*");
      try
             {
                 return fichiers[0].FullName;
             }

             catch
             {
                 return "null";
             }

        }
    }
}
