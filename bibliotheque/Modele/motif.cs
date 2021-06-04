using System;

namespace bibliotheque.Modele
{
    /// <summary>
    /// les motifs
    /// </summary>
    public class Motif
    {
        private readonly int idmotif;
        private readonly string libelle;

        /// <summary>
        /// getter idmotif
        /// </summary>
        public int Idmotif { get => idmotif; }

        /// <summary>
        /// getter libelle
        /// </summary>
        public string Libelle { get => libelle; }

        /// <summary>
        /// constructeur :valorise les proprietes
        /// </summary>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        /// <summary>
        /// Definit l'information a afficher
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}