namespace Hoarau_boutik
{
    partial class FrmStart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexionBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierSupprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierSupprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCommandesPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.fournToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.commandesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionBDDToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // connexionBDDToolStripMenuItem
            // 
            this.connexionBDDToolStripMenuItem.Name = "connexionBDDToolStripMenuItem";
            this.connexionBDDToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.connexionBDDToolStripMenuItem.Text = "Connexion BDD";
            this.connexionBDDToolStripMenuItem.Click += new System.EventHandler(this.ConnexionBDDToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitterToolStripMenuItem_Click);
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterModifierSupprimerToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.clientsToolStripMenuItem.Enabled = false;
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterModifierSupprimerToolStripMenuItem
            // 
            this.ajouterModifierSupprimerToolStripMenuItem.Name = "ajouterModifierSupprimerToolStripMenuItem";
            this.ajouterModifierSupprimerToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ajouterModifierSupprimerToolStripMenuItem.Text = "Ajouter/Modifier/Supprimer";
            this.ajouterModifierSupprimerToolStripMenuItem.Click += new System.EventHandler(this.AjouterModifierSupprimerToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.rechercherToolStripMenuItem.Text = "Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.RechercherToolStripMenuItem_Click);
            // 
            // fournToolStripMenuItem
            // 
            this.fournToolStripMenuItem.Enabled = false;
            this.fournToolStripMenuItem.Name = "fournToolStripMenuItem";
            this.fournToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fournToolStripMenuItem.Text = "Fournisseur";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterModifierSupprimerToolStripMenuItem1,
            this.rechercherToolStripMenuItem1});
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitToolStripMenuItem.Text = "Produits";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.ProduitToolStripMenuItem_Click);
            // 
            // ajouterModifierSupprimerToolStripMenuItem1
            // 
            this.ajouterModifierSupprimerToolStripMenuItem1.Name = "ajouterModifierSupprimerToolStripMenuItem1";
            this.ajouterModifierSupprimerToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.ajouterModifierSupprimerToolStripMenuItem1.Text = "Ajouter / Modifier / Supprimer";
            this.ajouterModifierSupprimerToolStripMenuItem1.Click += new System.EventHandler(this.AjouterModifierSupprimerToolStripMenuItem1_Click);
            // 
            // rechercherToolStripMenuItem1
            // 
            this.rechercherToolStripMenuItem1.Name = "rechercherToolStripMenuItem1";
            this.rechercherToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.rechercherToolStripMenuItem1.Text = "Rechercher";
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listesCommandesToolStripMenuItem,
            this.listeCommandesPSToolStripMenuItem});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // listesCommandesToolStripMenuItem
            // 
            this.listesCommandesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listesCommandesToolStripMenuItem.Name = "listesCommandesToolStripMenuItem";
            this.listesCommandesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listesCommandesToolStripMenuItem.Text = "Liste Commandes";
            this.listesCommandesToolStripMenuItem.Click += new System.EventHandler(this.listesCommandesToolStripMenuItem_Click);
            // 
            // listeCommandesPSToolStripMenuItem
            // 
            this.listeCommandesPSToolStripMenuItem.Name = "listeCommandesPSToolStripMenuItem";
            this.listeCommandesPSToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listeCommandesPSToolStripMenuItem.Text = "Liste Commandes PS";
            this.listeCommandesPSToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesPSToolStripMenuItem_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 574);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStart";
            this.Text = "Gestion Boutik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexionBDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem fournToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierSupprimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierSupprimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesPSToolStripMenuItem;
    }
}

