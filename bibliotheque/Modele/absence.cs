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
        private string motif;

        public DateTime DateDebut { get => dateDebut; }
        public DateTime DateFin { get => dateFin; }

        public int IdMotif { get => idmotif; }
        public string Motif { get => motif; }

        /// <summary>
        /// constructeur de classe
        /// </summary>
        public Absence(DateTime dateDebut, DateTime dateFin, int idmotif, string motif)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idmotif = idmotif;
            this.motif = motif;
          
        }
    }
}