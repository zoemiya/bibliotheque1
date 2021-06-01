using System;

namespace bibliotheque.Modele
{
    /// <summary>
    /// les motifs
    /// </summary>
    public class Motif
    {
        private int idmotif;
        private string libelle;

        public int Idmotif { get => idmotif; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// constructeur de classe
        /// </summary>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }
    }
}