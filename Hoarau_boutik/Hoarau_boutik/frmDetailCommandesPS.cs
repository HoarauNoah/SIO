using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoarau_boutik
{
    public partial class frmDetailCommandesPS : Form
    {
        public frmDetailCommandesPS(int numCom, string date, string nomClient)
        {
            InitializeComponent();
            tbNumero.Text = numCom.ToString();
            tbDate.Text = date;
            tbClient.Text = nomClient;
            numCommande = numCom;
        }
        public DataTable leDetailCommande;
        public DataTable lesCategories;
        public DataTable lesProduits;
        public int numCommande;

        private void frmDetailCommandesPS_Load(object sender, EventArgs e)
        {

            leDetailCommande = GestionPS.PSgetDetailsCommande(Convert.ToInt32(tbNumero.Text));
            lesCategories = GestionPS.PSgetLesCategories();
            lesProduits = GestionPS.PSgetProduitByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
            refresh();
        }

        private void refresh()
        {

            leDetailCommande.Clear();
            leDetailCommande = GestionPS.PSgetDetailsCommande(Convert.ToInt32(tbNumero.Text));
            dgProduitsCommande.DataSource = leDetailCommande;

            lesCategories.Clear();
            lesCategories = GestionPS.PSgetLesCategories();
            cbCategorie.DataSource = lesCategories;
            cbCategorie.DisplayMember = "LibelleCategorie";
            cbCategorie.ValueMember = "idCategorie";

            lesProduits.Clear();
            lesProduits = GestionPS.PSgetProduitByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
            cbProduit.DataSource = lesProduits;
            cbProduit.DisplayMember = "LibelleProduit";
            cbProduit.ValueMember = "idProduit";

        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lesProduits.Clear();
                lesProduits = GestionPS.PSgetProduitByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
                cbProduit.DataSource = lesProduits;
                cbProduit.DisplayMember = "LibelleProduit";
                cbProduit.ValueMember = "idProduit";
            }
            catch (Exception)
            {
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (tbQuantite.Text != "")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Êtes-vous sûr d'ajouter le produit " + cbProduit.Text + " en quantité " + tbQuantite.Text + " à la commande ?", "Information", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        if (GestionPS.PSGetQteProduitCommande(numCommande, Convert.ToInt32(cbProduit.SelectedValue)) == 0)
                        {

                            GestionPS.PSInsertProduitByCommande(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text));
                            MessageBox.Show("Produit ajouté à la commande !");
                            refresh();
                        }

                        else
                        {
                            DialogResult resultat = MessageBox.Show("Le produit " + cbProduit.Text + " est déjà présent dans la commande, ajouter la nouvelle quantité ? \n Si non, l'ancienne quantité sera remplacée par la nouvelle ", "Information", MessageBoxButtons.YesNo);
                            if (resultat == DialogResult.Yes)
                            {
                                int qte = GestionPS.PSGetQteProduitCommande(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue));
                                GestionPS.PSChangeQteProduitCommande(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text) + qte);
                            }
                            else
                            {

                                GestionPS.PSChangeQteProduitCommande(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text));
                            }
                            MessageBox.Show("Quantité modifiée !");
                            refresh();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

