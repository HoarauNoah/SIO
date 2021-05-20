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
    public partial class FrmListeClients : Form
    {
        public FrmListeClients()
        {
            InitializeComponent();

            dgListeClients.DataSource = GestionFournisseur.getAll();
        }

      
    }
}
