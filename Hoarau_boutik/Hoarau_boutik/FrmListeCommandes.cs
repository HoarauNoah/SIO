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
    public partial class FrmListeCommandes : Form
    {
        public FrmListeCommandes()
        {
            InitializeComponent();
        }
        public DataTable lesCommandes = GestionCommande.getAll();
        int position;
        bool antiActivated = false;
        private void FrmListeCommandes_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            refreshData();
        }

        public void refreshData()
        {
            lesCommandes.Clear();
            cbClient.DataSource = null;
            cbClient.DisplayMember = null;
            cbClient.ValueMember = null;
            lesCommandes = GestionCommande.getAll();
            cbClient.DataSource = GestionClient.getAll();
            cbClient.DisplayMember = "NomClient";
            cbClient.ValueMember = "idClient";
            dgCommandes.DataSource = GestionCommande.getLesCommandesDG();
            position = 0;
            rafraichirInterface();
        }
        public void rafraichirInterface()
        {
            if (position > -1)
            {
                tbNumero.Text = lesCommandes.Rows[position].ItemArray[0].ToString();
                tbDate.Text = lesCommandes.Rows[position].ItemArray[1].ToString();
                cbClient.SelectedValue = lesCommandes.Rows[position].ItemArray[2].ToString();
            }
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (position < GestionCommande.getNbCommandes() - 1)
            {
                position++;
                rafraichirInterface();
            }
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            rafraichirInterface();    
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (position > 0)
            {
                position = position - 1;
                rafraichirInterface();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            position = GestionCommande.getNbCommandes() - 1;
            rafraichirInterface();
        }

        private void btnAjoutCommande_Click(object sender, EventArgs e)
        {
            if(btnAjoutCommande.Text == "Ajouter une Commande")
            {
                btnAjoutCommande.Text = "Valider";
                tbDate.Text = "";
                cbClient.Text = "";
                cbClient.Enabled = true;
                tbDate.Enabled = true;
                btnDernier.Enabled = false;
                btnPrecedent.Enabled = false;
                btnSuivant.Enabled = false;
                btnPremier.Enabled = false;
                btnSupprCommande.Enabled = false;
                btnConsulterCommande.Enabled = false;
                tbNumero.Text = Convert.ToString(GestionBoutique.genererClePrimaire("idCommande", "commande"));
            }
            else
            {
                if (tbNumero.Text != "" && cbClient.Text != "" && tbDate.Text !="")
                {
                    GestionCommande.add(Convert.ToInt32(tbNumero.Text), tbDate.Text, Convert.ToInt32(cbClient.SelectedValue));
                    btnAjoutCommande.Text = "Ajouter une Commande";
                    MessageBox.Show("Commande ajoutée !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshData();
                    cbClient.Enabled = false;
                    tbDate.Enabled = false;
                    btnDernier.Enabled = true;
                    btnPrecedent.Enabled = true;
                    btnSuivant.Enabled = true;
                    btnPremier.Enabled = true;
                    btnSupprCommande.Enabled = true;
                    btnConsulterCommande.Enabled = true;


                    btnDernier.PerformClick();
                    btnConsulterCommande.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erreur, un champ n'est pas ou est mal spécifié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSupprCommande_Click(object sender, EventArgs e)
        {
            DialogResult rep;
            rep = MessageBox.Show("Êtes-vous sûr de supprimer la commande n°" + tbNumero.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                GestionCommande.del(Convert.ToInt32(tbNumero.Text));
                MessageBox.Show("Commande supprimée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
                
            }
        }

        private void btnModifCommande_Click(object sender, EventArgs e)
        {
            frmDetailsCommande frmDetailsCommande = new frmDetailsCommande(Convert.ToInt32(tbNumero.Text),tbDate.Text, cbClient.Text);
            antiActivated = true;
            frmDetailsCommande.ShowDialog();
            //DialogResult rep;
            //rep = MessageBox.Show("Êtes-vous sûr de modifier la commande n°"+ tbNumero.Text +"?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (rep == DialogResult.Yes)
            //{
            //    GestionCommande.change(Convert.ToInt32(tbNumero.Text), tbDate.Text, Convert.ToInt32(cbClient.SelectedValue));
            //    MessageBox.Show("Commande modifiée !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    refreshData();
            //    rafraichirInterface();
            //}
        }

        private void FrmListeCommandes_Activated(object sender, EventArgs e)
        {
            if (antiActivated)
            {
                antiActivated = false;
                refreshData();
            }
            
        }
    }
}
