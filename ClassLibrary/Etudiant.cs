using System;
using System.Collections.Generic;
namespace ClassLibrary
{
    public class Etudiant
    {
       
        public static int Increment { get; set; }
        public int NumeroEtudiant{get;private set;}
        public string Nom { get; set; }
        public string Prenom {get;set;}
        public List<Cours> CoursIncrits { get; set; }

        //constructeur
        public Etudiant(string nom, string prenom)
        {
            Increment++;
            this.NumeroEtudiant = Increment;
            this.Nom = nom.ToUpper();
            this.Prenom = prenom.ToUpper();
            this.CoursIncrits = new List<Cours>();
        }

        public Etudiant(string nom, string prenom, List<Cours> coursIncrits)
            :this( nom,  prenom)
        {
            this.CoursIncrits = coursIncrits;
        }

        //methodes

        /// <summary>
        /// inscrireEtudiant permettent d'inscrire un etudiant a un cours
        /// </summary>
        
        public void inscrireEtudiant(Cours cours)
        {
            this.CoursIncrits.Add(cours);
            cours.EtudiantsInscrits.Add(this);
        }

        //Tostring
        public override string ToString()
        {
            return $"NUMÉRO D'ÉTUDIANT : {this.NumeroEtudiant}\n"+
                  $"PRÉNOM : {this.Prenom}\n" +
                   $"NOM : {this.Nom}\n" +
                   $"Cours pris : \n";
        }


    }
}
