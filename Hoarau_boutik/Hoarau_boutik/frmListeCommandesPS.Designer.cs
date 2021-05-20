namespace Hoarau_boutik
{
    partial class frmListeCommandesPS
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
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnSupprCommande = new System.Windows.Forms.Button();
            this.btnConsulterCommande = new System.Windows.Forms.Button();
            this.btnAjoutCommande = new System.Windows.Forms.Button();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.grpDG = new System.Windows.Forms.GroupBox();
            this.dgCommandes = new System.Windows.Forms.DataGridView();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btnPremier = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.grbSelection = new System.Windows.Forms.GroupBox();
            this.btnDernier = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.checkBoxPaye = new System.Windows.Forms.CheckBox();
            this.grpDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCommandes)).BeginInit();
            this.grbSelection.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(281, 431);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(255, 39);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            // 
            // btnSupprCommande
            // 
            this.btnSupprCommande.Location = new System.Drawing.Point(531, 86);
            this.btnSupprCommande.Name = "btnSupprCommande";
            this.btnSupprCommande.Size = new System.Drawing.Size(238, 23);
            this.btnSupprCommande.TabIndex = 8;
            this.btnSupprCommande.Text = "Supprimer une Commande";
            this.btnSupprCommande.UseVisualStyleBackColor = true;
            this.btnSupprCommande.Click += new System.EventHandler(this.btnSupprCommande_Click);
            // 
            // btnConsulterCommande
            // 
            this.btnConsulterCommande.Location = new System.Drawing.Point(531, 63);
            this.btnConsulterCommande.Name = "btnConsulterCommande";
            this.btnConsulterCommande.Size = new System.Drawing.Size(238, 21);
            this.btnConsulterCommande.TabIndex = 7;
            this.btnConsulterCommande.Text = "Consulter une Commande";
            this.btnConsulterCommande.UseVisualStyleBackColor = true;
            this.btnConsulterCommande.Click += new System.EventHandler(this.btnConsulterCommande_Click);
            // 
            // btnAjoutCommande
            // 
            this.btnAjoutCommande.Location = new System.Drawing.Point(531, 35);
            this.btnAjoutCommande.Name = "btnAjoutCommande";
            this.btnAjoutCommande.Size = new System.Drawing.Size(238, 23);
            this.btnAjoutCommande.TabIndex = 6;
            this.btnAjoutCommande.Text = "Ajouter une Commande";
            this.btnAjoutCommande.UseVisualStyleBackColor = true;
            this.btnAjoutCommande.Click += new System.EventHandler(this.btnAjoutCommande_Click);
            // 
            // cbClient
            // 
            this.cbClient.Enabled = false;
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(78, 88);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(282, 21);
            this.cbClient.TabIndex = 5;
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(78, 63);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(282, 20);
            this.tbDate.TabIndex = 4;
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(78, 37);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(282, 20);
            this.tbNumero.TabIndex = 3;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(22, 91);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client :";
            // 
            // grpDG
            // 
            this.grpDG.Controls.Add(this.dgCommandes);
            this.grpDG.Location = new System.Drawing.Point(13, 256);
            this.grpDG.Name = "grpDG";
            this.grpDG.Size = new System.Drawing.Size(769, 169);
            this.grpDG.TabIndex = 6;
            this.grpDG.TabStop = false;
            this.grpDG.Text = "Récapitulatif des Commandes";
            // 
            // dgCommandes
            // 
            this.dgCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCommandes.Location = new System.Drawing.Point(0, 20);
            this.dgCommandes.Name = "dgCommandes";
            this.dgCommandes.Size = new System.Drawing.Size(763, 143);
            this.dgCommandes.TabIndex = 0;
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(378, 19);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(64, 38);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(296, 19);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(64, 38);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(217, 19);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(64, 38);
            this.btnPremier.TabIndex = 0;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 66);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date :";
            // 
            // grbSelection
            // 
            this.grbSelection.Controls.Add(this.btnDernier);
            this.grbSelection.Controls.Add(this.btnSuivant);
            this.grbSelection.Controls.Add(this.btnPrecedent);
            this.grbSelection.Controls.Add(this.btnPremier);
            this.grbSelection.Location = new System.Drawing.Point(13, 172);
            this.grbSelection.Name = "grbSelection";
            this.grbSelection.Size = new System.Drawing.Size(775, 63);
            this.grbSelection.TabIndex = 5;
            this.grbSelection.TabStop = false;
            this.grbSelection.Text = "Rechercher une Commande";
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(459, 19);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(64, 38);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(22, 40);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Numéro :";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.checkBoxPaye);
            this.grbInfo.Controls.Add(this.btnSupprCommande);
            this.grbInfo.Controls.Add(this.btnConsulterCommande);
            this.grbInfo.Controls.Add(this.btnAjoutCommande);
            this.grbInfo.Controls.Add(this.cbClient);
            this.grbInfo.Controls.Add(this.tbDate);
            this.grbInfo.Controls.Add(this.tbNumero);
            this.grbInfo.Controls.Add(this.lblClient);
            this.grbInfo.Controls.Add(this.lblDate);
            this.grbInfo.Controls.Add(this.lblNumero);
            this.grbInfo.Location = new System.Drawing.Point(13, 12);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(775, 139);
            this.grbInfo.TabIndex = 4;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Informations de Commande";
            // 
            // checkBoxPaye
            // 
            this.checkBoxPaye.AutoSize = true;
            this.checkBoxPaye.Location = new System.Drawing.Point(531, 115);
            this.checkBoxPaye.Name = "checkBoxPaye";
            this.checkBoxPaye.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPaye.TabIndex = 10;
            this.checkBoxPaye.Text = "Est payé";
            this.checkBoxPaye.UseVisualStyleBackColor = true;
            this.checkBoxPaye.Click += new System.EventHandler(this.checkBoxPaye_Click);
            // 
            // frmListeCommandesPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 482);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.grpDG);
            this.Controls.Add(this.grbSelection);
            this.Controls.Add(this.grbInfo);
            this.Name = "frmListeCommandesPS";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCommandes)).EndInit();
            this.grbSelection.ResumeLayout(false);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnSupprCommande;
        private System.Windows.Forms.Button btnConsulterCommande;
        private System.Windows.Forms.Button btnAjoutCommande;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox grpDG;
        private System.Windows.Forms.DataGridView dgCommandes;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grbSelection;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.CheckBox checkBoxPaye;
    }
}