using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hoarau_boutik
{
    public partial class FrmAMSProduits : Form
    {

        public FrmAMSProduits()
        {
            InitializeComponent();
        }

        public DataTable mesProduits = GestionProduit.getAll();
        public
        int position = 0;
        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAMSProduits_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            refreshData();
            cbFournisseur.DataSource = GestionFournisseur.getAll();
            cbFournisseur.DisplayMember = "NomFournisseur";
            cbFournisseur.ValueMember = "idFournisseur";
            cbCategories.DataSource = GestionCategorie.getAll();
            cbCategories.DisplayMember = "LibelleCategorie";
            cbCategories.ValueMember = "idCategorie";
            dgProduits.DataSource = GestionProduit.getSelected();

        }
        public void refreshData()
        {
            mesProduits.Clear();
            mesProduits = GestionProduit.getAll();

            position = 0;
            rafraichirInterface();
        }
        public void rafraichirInterface()
        {
            if (position > -1)
            {
                tbId.Text = mesProduits.Rows[position].ItemArray[0].ToString();
                tbLibelle.Text = mesProduits.Rows[position].ItemArray[1].ToString();
                tbPrixHT.Text = mesProduits.Rows[position].ItemArray[2].ToString();
                tbQteStock.Text = mesProduits.Rows[position].ItemArray[3].ToString();
                cbFournisseur.SelectedValue = mesProduits.Rows[position].ItemArray[4].ToString();
                cbCategories.SelectedValue = mesProduits.Rows[position].ItemArray[5].ToString();

            }
        }

        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            if (position < GestionProduit.getNbProduit() - 1)
            {
                position++;
                rafraichirInterface();
            }
        }

        private void Btn1er_Click(object sender, EventArgs e)
        {
            position = 0;
            rafraichirInterface();
        }

        private void BtnDernier_Click(object sender, EventArgs e)
        {
            position = GestionProduit.getNbProduit() - 1;
            rafraichirInterface();
        }

        private void BtnPrecedent_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position = position - 1;
                rafraichirInterface();
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "+")
            {
                btnAjouter.Text = "Valider";
                tbLibelle.Text = "";
                tbPrixHT.Text = "";
                tbQteStock.Text = "";
                tbId.Text = Convert.ToString(GestionBoutique.genererClePrimaire("idProduit", "produit"));

            }
            else
            {
                if (tbLibelle.Text != "" && tbPrixHT.Text != "" && tbQteStock.Text != "" && Convert.ToInt32(errorProvider1.Tag) == 0 && Convert.ToInt32(errorProvider2.Tag) == 0 && Convert.ToInt32(errorProvider3.Tag) == 0)
                {
                    GestionProduit.add(Convert.ToInt32(tbId.Text), tbLibelle.Text, Convert.ToInt32(tbPrixHT.Text), Convert.ToInt32(tbQteStock.Text), Convert.ToInt32(cbFournisseur.SelectedValue), Convert.ToInt32(cbCategories.SelectedValue));
                    btnAjouter.Text = "+";
                    MessageBox.Show("Client(e) ajouté !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    rafraichirInterface();
                    // MesClients.Clear();
                }
                else
                {
                    MessageBox.Show("Erreur, un champ n'est pas ou est mal spécifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void TbLibelle_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[a-zA-Z0-9ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÇçÌÍÎÏìíîïÙÚÛÜùúûüÿÑñ_-]");
            if (!rgx.IsMatch(tbLibelle.Text))
            {
                errorProvider1.SetError(tbLibelle, "Vide / Caractère interdit !");
                errorProvider1.Tag = 1;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.Tag = 0;
            }
        }

        private void TbPrixHT_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[0-9]+?[.][0-9]{2}?");
            if (!rgx.IsMatch(tbPrixHT.Text))
            {
                errorProvider2.SetError(tbPrixHT, "Vide / Caractère interdit !");
                errorProvider2.Tag = 1;
            }
            else
            {
                errorProvider2.Clear();
                errorProvider2.Tag = 0;
            }
        }
    }
}
