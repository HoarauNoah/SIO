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
    public partial class FrmBDD : Form
    {
        public FrmBDD()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbNomBDD.Text = "";
            tbNomServeur.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            GestionBoutique.maChaine = "Server ="+ tbNomServeur.Text +"; Database = "+ tbNomBDD.Text + "; Uid = root; Pwd =; ";
            GestionBoutique.seConnecter();
            ((FrmStart)this.MdiParent).clientsToolStripMenuItem.Enabled = true;
            this.Close();
        }
    }
}
