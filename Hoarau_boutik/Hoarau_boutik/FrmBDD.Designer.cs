namespace Hoarau_boutik
{
    partial class FrmBDD
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
            this.lblNomServeur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomServeur = new System.Windows.Forms.TextBox();
            this.tbNomBDD = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomServeur
            // 
            this.lblNomServeur.AutoSize = true;
            this.lblNomServeur.Location = new System.Drawing.Point(89, 29);
            this.lblNomServeur.Name = "lblNomServeur";
            this.lblNomServeur.Size = new System.Drawing.Size(90, 13);
            this.lblNomServeur.TabIndex = 0;
            this.lblNomServeur.Text = "Nom du Serveur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom de la Base de Données :";
            // 
            // tbNomServeur
            // 
            this.tbNomServeur.Location = new System.Drawing.Point(185, 26);
            this.tbNomServeur.Name = "tbNomServeur";
            this.tbNomServeur.Size = new System.Drawing.Size(224, 20);
            this.tbNomServeur.TabIndex = 2;
            this.tbNomServeur.Text = "localhost";
            // 
            // tbNomBDD
            // 
            this.tbNomBDD.Location = new System.Drawing.Point(185, 72);
            this.tbNomBDD.Name = "tbNomBDD";
            this.tbNomBDD.Size = new System.Drawing.Size(224, 20);
            this.tbNomBDD.TabIndex = 3;
            this.tbNomBDD.Text = "hoarau_PPE";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(92, 128);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(143, 46);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(344, 128);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(143, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 186);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbNomBDD);
            this.Controls.Add(this.tbNomServeur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNomServeur);
            this.Name = "FrmBDD";
            this.Text = "FrmBDD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomServeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomServeur;
        private System.Windows.Forms.TextBox tbNomBDD;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnReset;
    }
}