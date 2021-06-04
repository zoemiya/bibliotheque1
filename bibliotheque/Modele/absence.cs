using System;

namespace bibliotheque.Modele
{

    /// <summary>
    /// absences
    /// </summary>
    public class Absence
    {
        private readonly DateTime dateDebut ;
        private readonly DateTime dateFin;
        private readonly int idmotif;
        private readonly string motif;
        private readonly int idpersonnel;

        /// <summary>
        /// getter dateDebut
        /// </summary>
        public DateTime DateDebut { get => dateDebut; }

        /// <summary>
        /// getter dateFin
        /// </summary>
        public DateTime DateFin { get => dateFin; }

        /// <summary>
        /// getter idmotif
        /// </summary>
        public int IdMotif { get => idmotif; }

        /// <summary>
        /// getter motif
        /// </summary>
        public string Motif { get => motif; }

        /// <summary>
        /// getter idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// constructeur de classe
        /// </summary>
        public Absence(DateTime dateDebut, DateTime dateFin, int idmotif, string motif, int idpersonnel)
        {
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idmotif = idmotif;
            this.motif = motif;
            this.idpersonnel = idpersonnel;
          
        }
    }
}