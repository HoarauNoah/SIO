namespace Hoarau_boutik
{
    partial class FrmAMSProduits
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
            this.components = new System.ComponentModel.Container();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.lblPrixHT = new System.Windows.Forms.Label();
            this.lblQteStock = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblFournisseur = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbPrixHT = new System.Windows.Forms.TextBox();
            this.tbQteStock = new System.Windows.Forms.TextBox();
            this.cbFournisseur = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.dgProduits = new System.Windows.Forms.DataGridView();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSuppr = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.btn1er = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).BeginInit();
            this.gbGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(105, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(24, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID :";
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(86, 91);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(43, 13);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Libellé :";
            // 
            // lblPrixHT
            // 
            this.lblPrixHT.AutoSize = true;
            this.lblPrixHT.Location = new System.Drawing.Point(47, 117);
            this.lblPrixHT.Name = "lblPrixHT";
            this.lblPrixHT.Size = new System.Drawing.Size(82, 13);
            this.lblPrixHT.TabIndex = 2;
            this.lblPrixHT.Text = "Prix Hors-Taxe :";
            // 
            // lblQteStock
            // 
            this.lblQteStock.AutoSize = true;
            this.lblQteStock.Location = new System.Drawing.Point(47, 143);
            this.lblQteStock.Name = "lblQteStock";
            this.lblQteStock.Size = new System.Drawing.Size(82, 13);
            this.lblQteStock.TabIndex = 3;
            this.lblQteStock.Text = "Quantité stock :";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(71, 169);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 4;
            this.lblCategorie.Text = "Categorie :";
            // 
            // lblFournisseur
            // 
            this.lblFournisseur.AutoSize = true;
            this.lblFournisseur.Location = new System.Drawing.Point(65, 195);
            this.lblFournisseur.Name = "lblFournisseur";
            this.lblFournisseur.Size = new System.Drawing.Size(64, 13);
            this.lblFournisseur.TabIndex = 5;
            this.lblFournisseur.Text = "Founisseur :";
            // 
            // tbId
            // 
            this.tbId.Enabled = false;
            this.tbId.Location = new System.Drawing.Point(135, 62);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(294, 20);
            this.tbId.TabIndex = 6;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(135, 88);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(294, 20);
            this.tbLibelle.TabIndex = 7;
            this.tbLibelle.Leave += new System.EventHandler(this.TbLibelle_Leave);
            // 
            // tbPrixHT
            // 
            this.tbPrixHT.Location = new System.Drawing.Point(135, 114);
            this.tbPrixHT.Name = "tbPrixHT";
            this.tbPrixHT.Size = new System.Drawing.Size(294, 20);
            this.tbPrixHT.TabIndex = 8;
            this.tbPrixHT.Leave += new System.EventHandler(this.TbPrixHT_Leave);
            // 
            // tbQteStock
            // 
            this.tbQteStock.Location = new System.Drawing.Point(135, 140);
            this.tbQteStock.Name = "tbQteStock";
            this.tbQteStock.Size = new System.Drawing.Size(294, 20);
            this.tbQteStock.TabIndex = 9;
            // 
            // cbFournisseur
            // 
            this.cbFournisseur.FormattingEnabled = true;
            this.cbFournisseur.Location = new System.Drawing.Point(135, 193);
            this.cbFournisseur.Name = "cbFournisseur";
            this.cbFournisseur.Size = new System.Drawing.Size(294, 21);
            this.cbFournisseur.TabIndex = 10;
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(135, 166);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(294, 21);
            this.cbCategories.TabIndex = 11;
            // 
            // dgProduits
            // 
            this.dgProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduits.Location = new System.Drawing.Point(447, 25);
            this.dgProduits.Name = "dgProduits";
            this.dgProduits.Size = new System.Drawing.Size(413, 383);
            this.dgProduits.TabIndex = 12;
            // 
            // gbGestion
            // 
            this.gbGestion.Controls.Add(this.btnMod);
            this.gbGestion.Controls.Add(this.btnSuppr);
            this.gbGestion.Controls.Add(this.btnAjouter);
            this.gbGestion.Controls.Add(this.btnDernier);
            this.gbGestion.Controls.Add(this.btnSuivant);
            this.gbGestion.Controls.Add(this.btnPrecedent);
            this.gbGestion.Controls.Add(this.btn1er);
            this.gbGestion.Location = new System.Drawing.Point(50, 245);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(379, 81);
            this.gbGestion.TabIndex = 13;
            this.gbGestion.TabStop = false;
            this.gbGestion.Text = "Gestion";
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(208, 48);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(41, 23);
            this.btnMod.TabIndex = 6;
            this.btnMod.Text = "Mod.";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnSuppr
            // 
            this.btnSuppr.Location = new System.Drawing.Point(164, 48);
            this.btnSuppr.Name = "btnSuppr";
            this.btnSuppr.Size = new System.Drawing.Size(38, 23);
            this.btnSuppr.TabIndex = 5;
            this.btnSuppr.Text = "-";
            this.btnSuppr.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(120, 48);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(38, 23);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "+";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(233, 19);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(38, 23);
            this.btnDernier.TabIndex = 3;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.BtnDernier_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(189, 19);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(38, 23);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = ">";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.Location = new System.Drawing.Point(141, 19);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(38, 23);
            this.btnPrecedent.TabIndex = 1;
            this.btnPrecedent.Text = "<";
            this.btnPrecedent.UseVisualStyleBackColor = true;
            this.btnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // btn1er
            // 
            this.btn1er.Location = new System.Drawing.Point(97, 19);
            this.btn1er.Name = "btn1er";
            this.btn1er.Size = new System.Drawing.Size(38, 23);
            this.btn1er.TabIndex = 0;
            this.btn1er.Text = "<<";
            this.btn1er.UseVisualStyleBackColor = true;
            this.btn1er.Click += new System.EventHandler(this.Btn1er_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(180, 375);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(108, 23);
            this.btnFermer.TabIndex = 14;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // FrmAMSProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 450);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.gbGestion);
            this.Controls.Add(this.dgProduits);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.cbFournisseur);
            this.Controls.Add(this.tbQteStock);
            this.Controls.Add(this.tbPrixHT);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lblFournisseur);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblQteStock);
            this.Controls.Add(this.lblPrixHT);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.lblId);
            this.Name = "FrmAMSProduits";
            this.Text = "Ajouter / Modifier / Supprimer Produits";
            this.Load += new System.EventHandler(this.FrmAMSProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduits)).EndInit();
            this.gbGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.Label lblPrixHT;
        private System.Windows.Forms.Label lblQteStock;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblFournisseur;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbPrixHT;
        private System.Windows.Forms.TextBox tbQteStock;
        private System.Windows.Forms.ComboBox cbFournisseur;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.DataGridView dgProduits;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSuppr;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btn1er;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}