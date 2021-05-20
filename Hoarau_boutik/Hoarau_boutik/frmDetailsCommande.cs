using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoarau_boutik
{
    public partial class frmDetailsCommande : Form
    {
        public frmDetailsCommande(int numCom, string date, string nomClient)
        {
            InitializeComponent();
            tbNumero.Text = numCom.ToString();
            tbDate.Text = date;
            tbClient.Text = nomClient;

        }
        public DataTable leDetailCommande;
        public DataTable lesCategories;
        public DataTable lesProduits;
        private void frmDetailsCommande_Load(object sender, EventArgs e)
        {
            
            leDetailCommande = GestionCommande.getDetailsCommande(Convert.ToInt32(tbNumero.Text));
            lesCategories = GestionCategorie.getAll();
            lesProduits = GestionProduit.getByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
            refresh();

        }
        private void refresh()
        {

            leDetailCommande.Clear();
            leDetailCommande = GestionCommande.getDetailsCommande(Convert.ToInt32(tbNumero.Text));
            dgProduitsCommande.DataSource = leDetailCommande;

            lesCategories.Clear();
            lesCategories = GestionCategorie.getAll();
            cbCategorie.DataSource = lesCategories;
            cbCategorie.DisplayMember = "LibelleCategorie";
            cbCategorie.ValueMember = "idCategorie";

            lesProduits.Clear();
            lesProduits = GestionProduit.getByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
            cbProduit.DataSource = lesProduits;
            cbProduit.DisplayMember = "LibelleProduit";
            cbProduit.ValueMember = "idProduit";

        }

        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lesProduits.Clear();
                lesProduits = GestionProduit.getByIdCategorie(Convert.ToInt32(cbCategorie.SelectedValue));
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
                        GestionCommande.addProduit(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text));
                        MessageBox.Show("Produit ajouté à la commande !");
                        refresh();
                    }
                }
                catch (Exception)
                {
                    DialogResult result = MessageBox.Show("Le produit " + cbProduit.Text + " est déjà présent dans la commande, ajouter la nouvelle quantité ? \n Si non, l'ancienne quantité sera remplacée par la nouvelle ", "Information", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        int qte = GestionCommande.getQteProduitCommande(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue));
                        GestionCommande.changeQteProduit(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text) + qte);
                    }
                    else
                    {
                        GestionCommande.changeQteProduit(Convert.ToInt32(tbNumero.Text), Convert.ToInt32(cbProduit.SelectedValue), Convert.ToInt32(tbQuantite.Text));
                    }
                    MessageBox.Show("Quantité modifiée !");
                    refresh();

                }
            
            }
        }

        
    }
}
