using System;

namespace bibliotheque.Modele
{

    /// <summary>
    /// absences
    /// </summary>
    public class Absence
    {
        private DateTime dateDebut ;
        private DateTime dateFin;
        private int idmotif;

        public DateTime DateDebut { get => dateDebut; }
        public DateTime DateFin { get => dateFin; }

        public int IdMotif { get => idmotif; }

        /// <summary>
        /// constructeur de classe
        /// </summary>
        public Absence(DateTime dateDebut, DateTime dateFin, int idmotif)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idmotif = idmotif;
          
        }
    }
}