using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Notes
    {
        public int NumeroEtudiant { get; set; }
        public int NumeroCours { get; set; }
        public double Note { get; set; }

        public Notes(int numeroEtudiant, int numeroCours, double note)
        {
            this.NumeroEtudiant = numeroEtudiant;
            this.NumeroCours = numeroCours;
            this.Note = note;
        }
        //Pour donner une mention aux etudiant selon leur note moyenneGenerale.
        public static string getmention(double moyenneGenerale)
        {
            string mention = "";
            if (moyenneGenerale < 10)
            {
                mention = "Échec";
            }
            else if (moyenneGenerale >= 10 && moyenneGenerale < 12)
            {
                mention = "Acceptable";
            }
            else if (moyenneGenerale >= 12 && moyenneGenerale < 14)
            {
                mention = "Assez-bien";
            }
            else if (moyenneGenerale >= 14 && moyenneGenerale < 16)
            {
                mention = "Bien";
            }
            else if (moyenneGenerale >= 16 && moyenneGenerale < 19)
            {
                mention = "très bien";
            }
            else if (moyenneGenerale >= 19 && moyenneGenerale <= 20)
            {
                mention = "Exellent";
            }
            return mention;
        }
    }
}
