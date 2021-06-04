using System;

namespace bibliotheque.Modele
{
    /// <summary>
    /// classe des services
    /// </summary>
    public class Service
    {
        private readonly int idservice;
        private readonly string nom;

        /// <summary>
        /// getter idservice
        /// </summary>
        public int Idservice { get => idservice; }

        /// <summary>
        /// getter nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Constructeur 
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// definit l'info a afficher
        /// </summary>
        /// <returns>nom du service</returns>
        public override string ToString()
        {
            return nom;
        }
    }
}