using System;
using bibliotheque.Vue;
using bibliotheque.Modele;
using bibliotheque.Dal;
using System.Collections.Generic;

namespace bibliotheque.Controleur
{
    public class Controle
    {
       
            /// <summary>
            /// fenêtre d'authentification
            /// </summary>
        private frmAuthentification frmAuthentification;
        private frmBibliotheque frmBibliotheque;


        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new frmAuthentification(this);
            frmAuthentification.ShowDialog();
        }

        public Boolean ControleAuthentification(string login, string pwd)
        {
            if (AccesDonnees.ControleAuthentification(login, pwd))
            {
                frmAuthentification.Hide();
                (new frmBibliotheque(this)).ShowDialog();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Personnel> GetLePersonnel()
        {
            
            return AccesDonnees.GetLePersonnel();
        }

        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }
    
    }
}