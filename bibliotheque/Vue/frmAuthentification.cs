using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bibliotheque.Controleur;

namespace bibliotheque.Vue
{
    public partial class frmAuthentification : Form
    {
        private Controle controle;

        /// <summary>
        /// initialisation fenetre authentification
        /// </summary>
        /// <param name="controle"></param>
        public frmAuthentification(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.ControleAuthentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
        }
    }
}
