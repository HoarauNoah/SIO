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
    public partial class FrmAMSClients : Form
    {
        public FrmAMSClients()
        {
            InitializeComponent();
        }

        #region champs
        DataTable MesClients = GestionClient.getAll();
        int position = 0;
        #endregion

        public void rafraichirInterface()
        {
            if (position > -1)
            {
                tbId.Text = MesClients.Rows[position].ItemArray[0].ToString();
                tbNom.Text = MesClients.Rows[position].ItemArray[1].ToString();
                tbPrenom.Text = MesClients.Rows[position].ItemArray[2].ToString();
                tbAddresse.Text = MesClients.Rows[position].ItemArray[3].ToString();
                tbCodePostal.Text = MesClients.Rows[position].ItemArray[4].ToString();
                tbVille.Text = MesClients.Rows[position].ItemArray[5].ToString();
            }
        }

        public void refreshData()
        {
            MesClients.Clear();
            MesClients = GestionClient.getAll();
            position = 0;
        }
        private void FrmAMS_Load(object sender, EventArgs e)
        {
            this.Left = 0;
            this.Top = 0;
            //  DataTable MesClients = GestionClient.getAll();
            dgClients.DataSource = MesClients;
            rafraichirInterface();
        }



        private void FrmAMSClients_FormClosing(object sender, FormClosingEventArgs e)
        {
            GestionClient.Clear();
        }
        private void BtnSuivant_Click(object sender, EventArgs e)
        {
            if (position < GestionClient.getNbClient() - 1)
            {
                position++;
                rafraichirInterface();
            }
        }

        private void BtnPremier_Click(object sender, EventArgs e)
        {
            position = 0;
            rafraichirInterface();
        }

        private void BtnDernier_Click(object sender, EventArgs e)
        {
            position = GestionClient.getNbClient() - 1;
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

        private void BtnAjout_Click(object sender, EventArgs e)
        {
            if (btnAjout.Text == "+")
            {
                btnAjout.Text = "Valider";
                tbNom.Text = "";
                tbPrenom.Text = "";
                tbAddresse.Text = "";
                tbCodePostal.Text = "";
                tbId.Text = Convert.ToString(GestionBoutique.genererClePrimaire("idClient", "client"));
                tbVille.Text = "";
            }
            else
            {
                if (tbNom.Text != "" && tbPrenom.Text != "" && tbAddresse.Text != "" && tbCodePostal.Text != "" && tbVille.Text != ""&& Convert.ToInt32(errorProvider1.Tag) == 0 && Convert.ToInt32(errorProvider2.Tag) == 0 && Convert.ToInt32(errorProvider3.Tag) == 0 && Convert.ToInt32(errorProvider4.Tag) == 0 && Convert.ToInt32(errorProvider5.Tag) == 0 )
                {
                    GestionClient.add(Convert.ToInt32(tbId.Text), tbNom.Text, tbPrenom.Text, tbAddresse.Text, tbCodePostal.Text, tbVille.Text);
                    btnAjout.Text = "+";
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

        

        private void FrmAMSClients_FormClosed(object sender, FormClosedEventArgs e)
        {
            MesClients.Clear();
            
        }

        private void BtnSuppr_Click(object sender, EventArgs e)
        {
            string name = tbNom.Text;
            string prenom = tbPrenom.Text;
            DialogResult rep;
            rep = MessageBox.Show("Êtes-vous sûr de supprimer le client " + name + " " + prenom + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(tbId.Text);
                GestionClient.del(c);
                MessageBox.Show("Client supprimé !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
                rafraichirInterface();
            }
        }

        private void BtnModif_Click(object sender, EventArgs e)
        {
            string name = tbNom.Text;
            string prenom = tbPrenom.Text;
            DialogResult rep;
            rep = MessageBox.Show("Êtes-vous sûr de modifier le client " + name + " " + prenom + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rep == DialogResult.Yes)
            {
                int c = Convert.ToInt32(tbId.Text);
                GestionClient.change(c, tbNom.Text, tbPrenom.Text, tbAddresse.Text, tbCodePostal.Text, tbVille.Text);
                MessageBox.Show("Client modifié !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshData();
                rafraichirInterface();
            }
        }
        private void TbNom_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if (!rgx.IsMatch(tbNom.Text))
            {
                errorProvider1.SetError(tbNom, "Vide / Pas de nombre(s)!");
                errorProvider1.Tag = 1;
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.Tag = 0;
            }
        }

        private void TbPrenom_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if (!rgx.IsMatch(tbPrenom.Text))
            {
                errorProvider2.SetError(tbPrenom, "Vide / Pas de nombre(s)!");
                errorProvider2.Tag = 1;
            }
            else
            {
                errorProvider2.Clear();
                errorProvider2.Tag = 0;
            }
        }

        private void TbAddresse_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[a-zA-Z0-9ÀÁÂÃÄÅàáâãäåÒÓÔÕÖØòóôõöøÈÉÊËèéêëÇçÌÍÎÏìíîïÙÚÛÜùúûüÿÑñ_-]");
            if (!rgx.IsMatch(tbAddresse.Text))
            {
                errorProvider3.SetError(tbAddresse, "Vide / Caractère interdit !");
                errorProvider3.Tag = 1;
            }
            else
            {
                errorProvider3.Clear();
                errorProvider3.Tag = 0;
            }
        }

        private void TbCodePostal_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("^(([0-8][0-9])|(9[0-5])|(2[ab]))[0-9]{3}$");
            if(!rgx.IsMatch(tbCodePostal.Text))
            {
                errorProvider4.SetError(tbCodePostal, "Vide / Caractère Interdit !");
                errorProvider4.Tag = 1;
            }
            else
            {
                errorProvider4.Clear();
                errorProvider4.Tag = 0;
            }
        }

        private void TbVille_Leave(object sender, EventArgs e)
        {
            Regex rgx = new Regex("[^0-9]");
            if (!rgx.IsMatch(tbPrenom.Text))
            {
                errorProvider5.SetError(tbPrenom, "Vide / Pas de nombre(s)!");
                errorProvider5.Tag = 1;
            }
            else
            {
                errorProvider5.Clear();
                errorProvider5.Tag = 0;
            }
        }
    }
}
