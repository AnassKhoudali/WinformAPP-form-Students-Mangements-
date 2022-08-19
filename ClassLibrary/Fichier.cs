using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Globalization;

namespace ClassLibrary
{
    //cette class contient tous les methodes relatives a la creation de dossiers.
    public class Fichier
    {
        public string Nom { get; set; }
        public Fichier(string nom)
        {
            this.Nom = nom;
        }


        public void creerFichier(string lien)
        {
            if (!File.Exists(lien) == true)
            {
                StreamWriter sw = new StreamWriter(lien);
                sw.Close();
            }

        }

        public static int nombreDeCoursPris(List<string> donneesEtudiant)
        {
            int compteur = 0;
            foreach (string str in donneesEtudiant)
            {
                if (str.Contains("TITRE"))
                {
                    compteur++;
                }
            }
            return compteur;
        }


        public static int ajouterCellulesAuTbaleauNotes(List<string> donneesEtudiant, List<string> htmlFile)
        {
            int nbreCoursPris = Fichier.nombreDeCoursPris(donneesEtudiant);
            //cette variable retourne le nombre de Ligne ajouter a la grille de note.
            //la grille sur le fichier html contient 7 ligne par defaut.
            int NbreDeligneAjoutees = 0;
            if (nbreCoursPris > 5)
            {
                NbreDeligneAjoutees = nbreCoursPris - 5;
                for (int i = 0; i <= nbreCoursPris - 5; i++)
                {
                    List<string> casesHtml = new List<string>();
                    casesHtml.Add(@"<tr>");
                    casesHtml.Add(@"<td> </ td >");
                    casesHtml.Add(@"<td> </ td >");
                    casesHtml.Add(@"<td> </ td >");
                    casesHtml.Add(@"</tr>");

                    htmlFile.InsertRange(52, casesHtml);
                }
            }
            return NbreDeligneAjoutees;
        }

        //Cette fonction permet d'integrer les donner des etudiant contenues dans le fichier text au fichier html qui servira comme relevé de note.
        public static List<string> mergeIfo(List<string> donneesEtudiant, List<string> htmlFile)

        {
            double noteGenerale = 0;
            int NbreDeligneAjoutees = ajouterCellulesAuTbaleauNotes(donneesEtudiant, htmlFile);
            int nbreCoursPris = Fichier.nombreDeCoursPris(donneesEtudiant);
            int j = 0;
            for (int i = 15; i <= 17; i++)
            {
                try
                {
                    htmlFile[i] = htmlFile[i].Insert(htmlFile[i].IndexOf(":") + 1, " " + donneesEtudiant[j].Substring(donneesEtudiant[j].IndexOf(":") + 1).Trim());
                    j++;
                }
                catch
                {

                }

            }
            int f = 28;

            for (int k = 6; k < donneesEtudiant.Count; k++)
            {

                if (f <= htmlFile.Count && donneesEtudiant[k].Contains("TITRE"))
                {
                    try
                    {
                        htmlFile[f] = htmlFile[f].Insert(htmlFile[f].IndexOf("<td>") + 4, donneesEtudiant[k].Substring(donneesEtudiant[k].IndexOf(":") + 1).Trim());
                        k++;
                        f += 2;
                   
                        htmlFile[f] = htmlFile[f].Insert(htmlFile[f].IndexOf("<td>") + 4, donneesEtudiant[k].Substring(donneesEtudiant[k].IndexOf(":") + 1).Trim());
                        string str = donneesEtudiant[k].Substring(donneesEtudiant[k].IndexOf(":") + 1).Trim().ToString();
                        noteGenerale += double.Parse(str, CultureInfo.InvariantCulture);
                    }
                    catch
                    {

                    }

                    f += 3;
                }
            }
            

            Fichier.integrerMoyenneEtMention(htmlFile, noteGenerale / nbreCoursPris, 55 + (NbreDeligneAjoutees * 5));
           Fichier.integrerSceau(htmlFile, noteGenerale / nbreCoursPris, 62+(NbreDeligneAjoutees * 5));
            return htmlFile;
        }




        //Pour Ajouter La moyenne et la mention.
        public static void integrerMoyenneEtMention(List<string> htmlFile, double moyenneGenerale, int indiceDebutRecherche)
        {


            {
                for (int i = indiceDebutRecherche; i < htmlFile.Count; i++)
                {

                    if (htmlFile[i].Contains("Moyenne Générale :"))
                    {
                        htmlFile[i] = htmlFile[i].Insert(htmlFile[i].IndexOf(':') + 1, " "+moyenneGenerale);
                        htmlFile[i + 1] = htmlFile[i + 1].Insert(htmlFile[i + 1].IndexOf(':') + 1, " "+Notes.getmention(moyenneGenerale));

                    }
                }

            }
        }

        //Pour Ajouter le Scau de l'ecole.
        public static void integrerSceau(List<string> htmlFile, double moyenneGenerale, int indiceDebutRecherche)
        {
          
                string sceauLink = "";
                if (moyenneGenerale >= 10)
                {
                    sceauLink = "<img src=\"./authentic.png\" alt=\"scau\">";
                }
                else
                {
                    sceauLink = "<img src=\"./fail.png\" alt=\"scau\">";
                }

                for (int i = indiceDebutRecherche; i < htmlFile.Count; i++)
                {

                    if (htmlFile[i].Contains("\"Sceau\""))
                    {


                        htmlFile.Insert(i + 2, sceauLink);
                        

                    }
                }

            
        }
    }
}
  