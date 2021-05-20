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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConnexionBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBDD formulaire = new FrmBDD();
            formulaire.MdiParent = this;
            formulaire.Show();
        }

        private void AjouterModifierSupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAMSClients AMS = new FrmAMSClients();
            AMS.MdiParent = this;
            AMS.Show();
        }

        private void RechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheClient AMSRC = new FrmRechercheClient();
            AMSRC.MdiParent = this;
            AMSRC.Show();
        }

        private void ProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AjouterModifierSupprimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAMSProduits AMSP = new FrmAMSProduits();
            AMSP.MdiParent = this;
            AMSP.Show();
        }

        private void listesCommandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeCommandes frmListeCommandes = new FrmListeCommandes();
            frmListeCommandes.MdiParent = this;
            frmListeCommandes.Show();
        }

        private void listeCommandesPSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListeCommandesPS frmListeCommandesPS = new frmListeCommandesPS();
            frmListeCommandesPS.MdiParent = this;
            frmListeCommandesPS.Show();
        }


        //public void toolStripClient(Boolean bol)
        //{
        //    clientsToolStripMenuItem.Enabled = bol;
        //}
    }
}
