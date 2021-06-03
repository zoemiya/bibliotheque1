using System;
using bibliotheque.Vue;
using bibliotheque.Modele;
using bibliotheque.Dal;
using System.Collections.Generic;

namespace bibliotheque.Controleur
{
    /// <summary>
    /// gère les interactions entre la vue et le modèle
    /// </summary>
    public class Controle
    {
       
            /// <summary>
            /// fenêtre d'authentification
            /// </summary>
        private frmAuthentification frmAuthentification;


        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public Controle()
        {
            frmAuthentification = new frmAuthentification(this);
            frmAuthentification.ShowDialog();
        }


        /// <summary>
        /// Demande la vérification de l'authentification
        /// Si correct, alors ouvre la fenêtre principale
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Recupere et retourne les infos sur le personnel provenant de la BDD
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetLePersonnel()
        {
            
            return AccesDonnees.GetLePersonnel();
        }

        /// <summary>
        /// Recupere la liste des différents services provenant de la BDD
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return AccesDonnees.GetLesServices();
        }

        /// <summary>
        /// demande l'ajout d'un membre du personnel 
        /// </summary>
        /// <param name="personnel"> objet personnel a ajouter</param>
        public void AjouterPersonnel(Personnel personnel)
        {
            AccesDonnees.AjouterPersonnel(personnel);
        }
        
        /// <summary>
        /// demande la modification d'un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void ModifierPersonnel(Personnel personnel)
        {
            AccesDonnees.ModifierPersonnel(personnel);
        }

        public void SupprimerPersonnel(Personnel personnel)
        {
            AccesDonnees.SupprimerPersonnel(personnel);
        }

        public List<Absence> GetAbsences(Personnel personnel)
        {
            return AccesDonnees.GetAbsences(personnel);
        }

        public List<Motif> GetLesMotifs()
        {
            return AccesDonnees.GetLesMotifs();
        }

        public void AjouterAbsence(Absence absence)
        {
            AccesDonnees.AjouterAbsence(absence);
        }

        public void ModifierAbsence(Absence absence, DateTime dateDebutIni)
        {
            AccesDonnees.ModifierAbsence(absence, dateDebutIni);
        }
    
    }
}