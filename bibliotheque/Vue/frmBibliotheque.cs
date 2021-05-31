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
using bibliotheque.Modele;

namespace bibliotheque.Vue
{
    /// <summary>
    /// Fenêtre d'affichage des personnels et de leurs absences
    /// </summary>
    public partial class frmBibliotheque : Form
    {
        /// <summary>
        /// instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();

        BindingSource bdgService = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmBibliotheque(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        public void Init()
        {
            RemplirListePersonnel();
            RemplirListeServices();
            gbPersonnel.Enabled = false;
            gbAbsences.Enabled = false;
            
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controle.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// affiche les services dans la combobox
        /// </summary>
        public void RemplirListeServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bdgService.DataSource = lesServices;
            cbService.DataSource = bdgService;
            if (cbService.Items.Count > 0)
            {
                cbService.SelectedIndex = 0;
              
            }
        }

        private void btnEnregistrerP_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouterP_Click(object sender, EventArgs e)
        {
            gbPersonnel.Enabled = true;
                    }

        private void btnEnregistrerP_Click_1(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = dgvPersonnel.RowCount;
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                controle.AjouterPersonnel(personnel);
                RemplirListePersonnel();
            }
            else
            { MessageBox.Show("Tous les champs doivent être renseignés.", "Alerte"); }
        }

        private void btnAnnulerP_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtTel.Text = "";
            txtMail.Text = "";
            cbService.SelectedIndex = 0;
        }
    }
}
