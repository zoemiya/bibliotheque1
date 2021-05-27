using System;
using bibliotheque.vue;

namespace bibliotheque.Controleur
{
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
    
    }
}