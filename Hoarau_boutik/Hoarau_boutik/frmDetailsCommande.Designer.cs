namespace Hoarau_boutik
{
    partial class frmDetailsCommande
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
            this.gbInfoCommande = new System.Windows.Forms.GroupBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.gbListesDesProduits = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgProduitsCommande = new System.Windows.Forms.DataGridView();
            this.btnPDF = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbClient = new System.Windows.Forms.TextBox();
            this.gbInfoCommande.SuspendLayout();
            this.gbListesDesProduits.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduitsCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // gbInfoCommande
            // 
            this.gbInfoCommande.Controls.Add(this.tbClient);
            this.gbInfoCommande.Controls.Add(this.lblClient);
            this.gbInfoCommande.Controls.Add(this.lblDate);
            this.gbInfoCommande.Controls.Add(this.lblNumero);
            this.gbInfoCommande.Controls.Add(this.tbDate);
            this.gbInfoCommande.Controls.Add(this.tbNumero);
            this.gbInfoCommande.Location = new System.Drawing.Point(12, 12);
            this.gbInfoCommande.Name = "gbInfoCommande";
            this.gbInfoCommande.Size = new System.Drawing.Size(776, 108);
            this.gbInfoCommande.TabIndex = 0;
            this.gbInfoCommande.TabStop = false;
            this.gbInfoCommande.Text = "Informations de Commande";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(457, 34);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(39, 13);
            this.lblClient.TabIndex = 4;
            this.lblClient.Text = "Client :";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date :";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(7, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(50, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numéro :";
            // 
            // tbDate
            // 
            this.tbDate.Enabled = false;
            this.tbDate.Location = new System.Drawing.Point(63, 57);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(209, 20);
            this.tbDate.TabIndex = 1;
            // 
            // tbNumero
            // 
            this.tbNumero.Enabled = false;
            this.tbNumero.Location = new System.Drawing.Point(63, 31);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(209, 20);
            this.tbNumero.TabIndex = 0;
            // 
            // gbListesDesProduits
            // 
            this.gbListesDesProduits.Controls.Add(this.btnAjouter);
            this.gbListesDesProduits.Controls.Add(this.tbQuantite);
            this.gbListesDesProduits.Controls.Add(this.cbProduit);
            this.gbListesDesProduits.Controls.Add(this.cbCategorie);
            this.gbListesDesProduits.Controls.Add(this.lblQuantite);
            this.gbListesDesProduits.Controls.Add(this.lblProduit);
            this.gbListesDesProduits.Controls.Add(this.lblCategorie);
            this.gbListesDesProduits.Location = new System.Drawing.Point(12, 126);
            this.gbListesDesProduits.Name = "gbListesDesProduits";
            this.gbListesDesProduits.Size = new System.Drawing.Size(776, 111);
            this.gbListesDesProduits.TabIndex = 6;
            this.gbListesDesProduits.TabStop = false;
            this.gbListesDesProduits.Text = "Informations de Commande";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(450, 16);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(246, 82);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter à la commande";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(73, 82);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(246, 20);
            this.tbQuantite.TabIndex = 6;
            // 
            // cbProduit
            // 
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(73, 55);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(246, 21);
            this.cbProduit.TabIndex = 7;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(73, 28);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(246, 21);
            this.cbCategorie.TabIndex = 6;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(14, 85);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(53, 13);
            this.lblQuantite.TabIndex = 6;
            this.lblQuantite.Text = "Quantité :";
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(21, 58);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(46, 13);
            this.lblProduit.TabIndex = 3;
            this.lblProduit.Text = "Produit :";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(9, 31);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(58, 13);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Categorie :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgProduitsCommande);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Récapitulatif des produits de la commande";
            // 
            // dgProduitsCommande
            // 
            this.dgProduitsCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduitsCommande.Location = new System.Drawing.Point(7, 20);
            this.dgProduitsCommande.Name = "dgProduitsCommande";
            this.dgProduitsCommande.Size = new System.Drawing.Size(763, 136);
            this.dgProduitsCommande.TabIndex = 0;
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(111, 413);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(220, 32);
            this.btnPDF.TabIndex = 8;
            this.btnPDF.Text = "Importer au format PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbClient
            // 
            this.tbClient.Enabled = false;
            this.tbClient.Location = new System.Drawing.Point(502, 31);
            this.tbClient.Name = "tbClient";
            this.tbClient.Size = new System.Drawing.Size(209, 20);
            this.tbClient.TabIndex = 5;
            // 
            // frmDetailsCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbListesDesProduits);
            this.Controls.Add(this.gbInfoCommande);
            this.Name = "frmDetailsCommande";
            this.Text = "frmDetailsCommande";
            this.Load += new System.EventHandler(this.frmDetailsCommande_Load);
            this.gbInfoCommande.ResumeLayout(false);
            this.gbInfoCommande.PerformLayout();
            this.gbListesDesProduits.ResumeLayout(false);
            this.gbListesDesProduits.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduitsCommande)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoCommande;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.GroupBox gbListesDesProduits;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgProduitsCommande;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbClient;
    }
}