﻿using System;
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

        private Boolean enCoursDeModif = false;

        private Boolean enCoursDeModifA = false;

        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        BindingSource bdgPersonnel = new BindingSource();

        BindingSource bdgService = new BindingSource();

        

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bdgAbsences = new BindingSource();

        BindingSource bdgMotif = new BindingSource();

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
            gbPersonnel.Text = "";
            
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        public void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controle.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            
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
            gbPersonnel.Text = "ajouter un membre du personnel";
                    }

        private void btnEnregistrerP_Click_1(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                int idpersonnel = 0;
                if (enCoursDeModif)
                {
                    idpersonnel = ((Personnel)bdgPersonnel.List[bdgPersonnel.Position]).Idpersonnel;
                
                }
                Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service.Idservice, service.Nom);
                if (enCoursDeModif)
                {
                    controle.ModifierPersonnel(personnel);
                    enCoursDeModif = false;
                    gbPersonnel.Text = "";

                }
                else
                {
                    controle.AjouterPersonnel(personnel);
                }
                
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

        private void btnModifierP_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                gbPersonnel.Text = "modifierPersonnel";
                gbPersonnel.Enabled = true;
                enCoursDeModif = true;
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cbService.SelectedIndex = cbService.FindStringExact(personnel.Service);
               
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        
        }

        private void btnSupprimerP_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controle.SupprimerPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        
        }

        private void RemplirAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = controle.GetAbsences(personnel);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnAfficherAbsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirAbsences(personnel);
                btnAjouterA.Enabled = true;
                btnModifierA.Enabled = true;
                btnSupprimerA.Enabled = true;
                RemplirListeMotifs();
            }
        }

        private void btnAjouterA_Click(object sender, EventArgs e)
        {
            gbAbsences.Enabled = true;
            gbAbsences.Text = "Ajouter une absence";

        }

        public void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cbMotif.DataSource = bdgMotif;
            if (cbMotif.Items.Count > 0)
            {
                cbMotif.SelectedIndex = 0;

            }
        }

        private void btnEnregistrerA_Click(object sender, EventArgs e)
        {
            if( !(txtDebut.Text.Equals(""))&& !(txtFin.Text.Equals("")) && (cbMotif.SelectedIndex!=-1))
            {

            }
        }
    }
}
