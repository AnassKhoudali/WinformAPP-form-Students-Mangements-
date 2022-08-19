using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class Cours
    {
        public static int Increment { get; set; }
        public int NumeroCours { get; private set; }
        public string Code { get; set; }
        public string Titre { get; set; }

        public List<Etudiant> EtudiantsInscrits { get; set; }

        public Cours(string code, string titre)
        {
            Increment++;
            this.NumeroCours = Increment;
            this.Code = code;
            this.Titre = titre.ToUpper();
            this.EtudiantsInscrits = new List<Etudiant>();
        }

        /// <summary>
        /// inscrireEtudiant qui permet d'inscrire un etudiant a un cours.
        /// </summary>

        public void inscrireEtudiant(Etudiant etudiant)
        {
            etudiant.inscrireEtudiant(this);
        }

        //tostring
        public override string ToString()
        {
            return $"NUMÉRO DE COURS : {this.NumeroCours}\n" +
                   $"CODE DE COURS : {this.Code}\n" +
                   $"TITRE : {this.Titre}\n";
        }

    }
}

