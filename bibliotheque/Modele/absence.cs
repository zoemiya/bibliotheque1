using System;

namespace bibliotheque.Modele
{

    /// <summary>
    /// absences
    /// </summary>
    public class Absence
    {
        private int idabsence;
        private string nom;

        public int Idabsence { get => idabsence; }
        public string Nom { get => nom; }

        /// <summary>
        /// constructeur de classe
        /// </summary>
        public Absence(int idabsence, string nom)
        {
            this.idabsence = idabsence;
            this.nom = nom;
          
        }
    }
}