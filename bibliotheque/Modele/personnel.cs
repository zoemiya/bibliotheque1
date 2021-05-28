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
        private string nom;
        private string prenom;
        private string mail;
        private string tel;

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }

        /// <summary>
        /// Constructeur : valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="mail"></param>
        /// <param name="tel"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string mail, string tel)
        {
            this.idpersonnel = idpersonnel;
            this.idservice = idservice;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
        }
    }
}