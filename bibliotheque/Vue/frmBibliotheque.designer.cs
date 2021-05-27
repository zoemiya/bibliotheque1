
namespace bibliotheque.vue
{
    partial class frmBibliotheque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPersonnel = new System.Windows.Forms.ListBox();
            this.gbPersonnel = new System.Windows.Forms.GroupBox();
            this.gbAbsences = new System.Windows.Forms.GroupBox();
            this.lstAbsences = new System.Windows.Forms.ListBox();
            this.btnAjouterP = new System.Windows.Forms.Button();
            this.btnModifierP = new System.Windows.Forms.Button();
            this.btnSupprimerP = new System.Windows.Forms.Button();
            this.btnAfficherAbsence = new System.Windows.Forms.Button();
            this.btnAjouterA = new System.Windows.Forms.Button();
            this.btnModifierA = new System.Windows.Forms.Button();
            this.btnSupprimerA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.btnEnregistrerP = new System.Windows.Forms.Button();
            this.btnAnnulerP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.txtDebut = new System.Windows.Forms.TextBox();
            this.btnEnregistrerA = new System.Windows.Forms.Button();
            this.btnAnnulerA = new System.Windows.Forms.Button();
            this.gbPersonnel.SuspendLayout();
            this.gbAbsences.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonnel
            // 
            this.lstPersonnel.FormattingEnabled = true;
            this.lstPersonnel.Location = new System.Drawing.Point(395, 6);
            this.lstPersonnel.Name = "lstPersonnel";
            this.lstPersonnel.Size = new System.Drawing.Size(510, 173);
            this.lstPersonnel.TabIndex = 0;
            // 
            // gbPersonnel
            // 
            this.gbPersonnel.Controls.Add(this.btnAnnulerP);
            this.gbPersonnel.Controls.Add(this.btnEnregistrerP);
            this.gbPersonnel.Controls.Add(this.cbService);
            this.gbPersonnel.Controls.Add(this.txtNom);
            this.gbPersonnel.Controls.Add(this.txtPrenom);
            this.gbPersonnel.Controls.Add(this.txtMail);
            this.gbPersonnel.Controls.Add(this.txtTel);
            this.gbPersonnel.Controls.Add(this.label4);
            this.gbPersonnel.Controls.Add(this.label5);
            this.gbPersonnel.Controls.Add(this.label3);
            this.gbPersonnel.Controls.Add(this.label1);
            this.gbPersonnel.Controls.Add(this.label2);
            this.gbPersonnel.Enabled = false;
            this.gbPersonnel.Location = new System.Drawing.Point(12, 12);
            this.gbPersonnel.Name = "gbPersonnel";
            this.gbPersonnel.Size = new System.Drawing.Size(328, 224);
            this.gbPersonnel.TabIndex = 1;
            this.gbPersonnel.TabStop = false;
            this.gbPersonnel.Text = "ajoutPersonnel";
            // 
            // gbAbsences
            // 
            this.gbAbsences.Controls.Add(this.btnEnregistrerA);
            this.gbAbsences.Controls.Add(this.btnAnnulerA);
            this.gbAbsences.Controls.Add(this.cbMotif);
            this.gbAbsences.Controls.Add(this.txtFin);
            this.gbAbsences.Controls.Add(this.txtDebut);
            this.gbAbsences.Controls.Add(this.label7);
            this.gbAbsences.Controls.Add(this.label6);
            this.gbAbsences.Controls.Add(this.label8);
            this.gbAbsences.Enabled = false;
            this.gbAbsences.Location = new System.Drawing.Point(12, 258);
            this.gbAbsences.Name = "gbAbsences";
            this.gbAbsences.Size = new System.Drawing.Size(328, 180);
            this.gbAbsences.TabIndex = 0;
            this.gbAbsences.TabStop = false;
            this.gbAbsences.Text = "ajoutAbsence";
            // 
            // lstAbsences
            // 
            this.lstAbsences.FormattingEnabled = true;
            this.lstAbsences.Location = new System.Drawing.Point(395, 224);
            this.lstAbsences.Name = "lstAbsences";
            this.lstAbsences.Size = new System.Drawing.Size(510, 186);
            this.lstAbsences.TabIndex = 0;
            // 
            // btnAjouterP
            // 
            this.btnAjouterP.Location = new System.Drawing.Point(395, 185);
            this.btnAjouterP.Name = "btnAjouterP";
            this.btnAjouterP.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterP.TabIndex = 2;
            this.btnAjouterP.Text = "ajouter";
            this.btnAjouterP.UseVisualStyleBackColor = true;
            // 
            // btnModifierP
            // 
            this.btnModifierP.Location = new System.Drawing.Point(476, 185);
            this.btnModifierP.Name = "btnModifierP";
            this.btnModifierP.Size = new System.Drawing.Size(75, 23);
            this.btnModifierP.TabIndex = 3;
            this.btnModifierP.Text = "modifier";
            this.btnModifierP.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerP
            // 
            this.btnSupprimerP.Location = new System.Drawing.Point(557, 185);
            this.btnSupprimerP.Name = "btnSupprimerP";
            this.btnSupprimerP.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerP.TabIndex = 4;
            this.btnSupprimerP.Text = "supprimer";
            this.btnSupprimerP.UseVisualStyleBackColor = true;
            // 
            // btnAfficherAbsence
            // 
            this.btnAfficherAbsence.Location = new System.Drawing.Point(638, 185);
            this.btnAfficherAbsence.Name = "btnAfficherAbsence";
            this.btnAfficherAbsence.Size = new System.Drawing.Size(96, 23);
            this.btnAfficherAbsence.TabIndex = 5;
            this.btnAfficherAbsence.Text = "afficherAbsence";
            this.btnAfficherAbsence.UseVisualStyleBackColor = true;
            // 
            // btnAjouterA
            // 
            this.btnAjouterA.Location = new System.Drawing.Point(395, 416);
            this.btnAjouterA.Name = "btnAjouterA";
            this.btnAjouterA.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterA.TabIndex = 6;
            this.btnAjouterA.Text = "ajouter";
            this.btnAjouterA.UseVisualStyleBackColor = true;
            // 
            // btnModifierA
            // 
            this.btnModifierA.Location = new System.Drawing.Point(476, 416);
            this.btnModifierA.Name = "btnModifierA";
            this.btnModifierA.Size = new System.Drawing.Size(75, 23);
            this.btnModifierA.TabIndex = 7;
            this.btnModifierA.Text = "modifier";
            this.btnModifierA.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerA
            // 
            this.btnSupprimerA.Location = new System.Drawing.Point(557, 416);
            this.btnSupprimerA.Name = "btnSupprimerA";
            this.btnSupprimerA.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerA.TabIndex = 8;
            this.btnSupprimerA.Text = "supprimer";
            this.btnSupprimerA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "service d\'affectation";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(114, 120);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(144, 20);
            this.txtTel.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(114, 91);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(144, 20);
            this.txtMail.TabIndex = 6;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(114, 59);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(144, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(114, 29);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(144, 20);
            this.txtNom.TabIndex = 8;
            // 
            // cbService
            // 
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(114, 151);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(144, 21);
            this.cbService.TabIndex = 9;
            // 
            // btnEnregistrerP
            // 
            this.btnEnregistrerP.Location = new System.Drawing.Point(9, 183);
            this.btnEnregistrerP.Name = "btnEnregistrerP";
            this.btnEnregistrerP.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerP.TabIndex = 10;
            this.btnEnregistrerP.Text = "enregistrer";
            this.btnEnregistrerP.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerP
            // 
            this.btnAnnulerP.Location = new System.Drawing.Point(104, 183);
            this.btnAnnulerP.Name = "btnAnnulerP";
            this.btnAnnulerP.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerP.TabIndex = 11;
            this.btnAnnulerP.Text = "annuler";
            this.btnAnnulerP.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "motif";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "dateDebut";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "dateFin";
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(114, 80);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(144, 21);
            this.cbMotif.TabIndex = 15;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(114, 51);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(144, 20);
            this.txtFin.TabIndex = 16;
            // 
            // txtDebut
            // 
            this.txtDebut.Location = new System.Drawing.Point(114, 24);
            this.txtDebut.Name = "txtDebut";
            this.txtDebut.Size = new System.Drawing.Size(144, 20);
            this.txtDebut.TabIndex = 17;
            // 
            // btnEnregistrerA
            // 
            this.btnEnregistrerA.Location = new System.Drawing.Point(9, 118);
            this.btnEnregistrerA.Name = "btnEnregistrerA";
            this.btnEnregistrerA.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrerA.TabIndex = 12;
            this.btnEnregistrerA.Text = "enregistrer";
            this.btnEnregistrerA.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerA
            // 
            this.btnAnnulerA.Location = new System.Drawing.Point(104, 118);
            this.btnAnnulerA.Name = "btnAnnulerA";
            this.btnAnnulerA.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerA.TabIndex = 13;
            this.btnAnnulerA.Text = "annuler";
            this.btnAnnulerA.UseVisualStyleBackColor = true;
            // 
            // frmBibliotheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.btnSupprimerA);
            this.Controls.Add(this.btnModifierA);
            this.Controls.Add(this.btnAjouterA);
            this.Controls.Add(this.btnAfficherAbsence);
            this.Controls.Add(this.btnSupprimerP);
            this.Controls.Add(this.btnModifierP);
            this.Controls.Add(this.btnAjouterP);
            this.Controls.Add(this.lstAbsences);
            this.Controls.Add(this.gbAbsences);
            this.Controls.Add(this.gbPersonnel);
            this.Controls.Add(this.lstPersonnel);
            this.Name = "frmBibliotheque";
            this.Text = "frmBibliotheque";
            this.gbPersonnel.ResumeLayout(false);
            this.gbPersonnel.PerformLayout();
            this.gbAbsences.ResumeLayout(false);
            this.gbAbsences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonnel;
        private System.Windows.Forms.GroupBox gbPersonnel;
        private System.Windows.Forms.GroupBox gbAbsences;
        private System.Windows.Forms.ListBox lstAbsences;
        private System.Windows.Forms.Button btnAjouterP;
        private System.Windows.Forms.Button btnModifierP;
        private System.Windows.Forms.Button btnSupprimerP;
        private System.Windows.Forms.Button btnAfficherAbsence;
        private System.Windows.Forms.Button btnAjouterA;
        private System.Windows.Forms.Button btnModifierA;
        private System.Windows.Forms.Button btnSupprimerA;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnnulerP;
        private System.Windows.Forms.Button btnEnregistrerP;
        private System.Windows.Forms.Button btnEnregistrerA;
        private System.Windows.Forms.Button btnAnnulerA;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.TextBox txtFin;
        private System.Windows.Forms.TextBox txtDebut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}