namespace Hoarau_boutik
{
    partial class FrmRechercheClient
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
            this.dgClients = new System.Windows.Forms.DataGridView();
            this.tbRecherche = new System.Windows.Forms.TextBox();
            this.lblRecherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClients
            // 
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Location = new System.Drawing.Point(12, 12);
            this.dgClients.Name = "dgClients";
            this.dgClients.Size = new System.Drawing.Size(587, 267);
            this.dgClients.TabIndex = 0;
            // 
            // tbRecherche
            // 
            this.tbRecherche.Location = new System.Drawing.Point(180, 323);
            this.tbRecherche.Name = "tbRecherche";
            this.tbRecherche.Size = new System.Drawing.Size(245, 20);
            this.tbRecherche.TabIndex = 1;
            this.tbRecherche.TextChanged += new System.EventHandler(this.TbRecherche_TextChanged);
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(266, 307);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(73, 13);
            this.lblRecherche.TabIndex = 2;
            this.lblRecherche.Text = "Recherche:";
            // 
            // FrmRechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 355);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.tbRecherche);
            this.Controls.Add(this.dgClients);
            this.Name = "FrmRechercheClient";
            this.Text = "FrmRechercheClient";
            this.Load += new System.EventHandler(this.FrmRechercheClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClients;
        private System.Windows.Forms.TextBox tbRecherche;
        private System.Windows.Forms.Label lblRecherche;
    }
}