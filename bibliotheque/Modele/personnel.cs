using System;

namespace bibliotheque.Modele
{
    /// <summary>
    /// membres du personnel
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private int idservice;
        private string service;
        private string nom;
        private string prenom;
        private string mail;
        private string tel;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }

        public string Service { get => service; }

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