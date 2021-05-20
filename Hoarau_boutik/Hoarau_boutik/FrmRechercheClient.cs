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
    public partial class FrmRechercheClient : Form
    {
        #region Champs

        

        #endregion
        public FrmRechercheClient()
        {
            InitializeComponent();
        }

        private void FrmRechercheClient_Load(object sender, EventArgs e)
        {
            

        }

        private void TbRecherche_TextChanged(object sender, EventArgs e)
        {
            dgClients.DataSource = null;
            if (tbRecherche.Text != "")
            {
                DataTable recherche = GestionClient.search(tbRecherche.Text);
                dgClients.DataSource = recherche;
            }

            
        }
    }
}
