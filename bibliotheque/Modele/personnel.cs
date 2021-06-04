using System;

namespace bibliotheque.Modele
{
    /// <summary>
    /// membres du personnel
    /// </summary>
    public class Personnel
    {
        private readonly int idpersonnel;
        private readonly int idservice;
        private readonly string service;
        private readonly string nom;
        private readonly string prenom;
        private readonly string mail;
        private readonly string tel;

        /// <summary>
        /// getter idpersonnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }

        /// <summary>
        /// getter nom
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// getter prenom
        /// </summary>
        public string Prenom { get => prenom; }

        /// <summary>
        /// getter tel
        /// </summary>
        public string Tel { get => tel; }

        /// <summary>
        /// getter mail
        /// </summary>
        public string Mail { get => mail; }

        /// <summary>
        /// getter service
        /// </summary>
        public string Service { get => service; }

        /// <summary>
        /// getter idservice
        /// </summary>
        public int Idservice { get => idservice; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="service"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="tel"></param>
        /// <param name="idservice"></param>
        public Personnel(int idpersonnel, string nom, string prenom, string mail, string tel, int idservice, string service)
        {
            this.idpersonnel = idpersonnel;
            this.service = service;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
        }
    }
}