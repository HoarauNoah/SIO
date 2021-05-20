using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoarau_boutik
{
    class GestionPS
    {
        public static DataTable PSgetLesCommandes()
        {
            return GestionBoutique.getLesTuplesByRequete("call GetAllCommandes", "ToutesLesCommandes");
        }

        public static DataTable PSGetLesClients()
        {
            return GestionBoutique.getLesTuplesByRequete("call GetAllClients", "ToutLesClients");
        }

        public static void PSDeleteCommandeById(int id)
        {
            GestionBoutique.executerRequeteNonQuery("call DeleteCommandeById(" + Convert.ToString(id) + ")");
        }

        public static void PSAddCommande(int idCom, string DateCom, int idCli)
        {
            GestionBoutique.executerRequeteNonQuery("call InsertCommande(" + Convert.ToString(idCom) + ", '" + DateCom + "', " + Convert.ToString(idCli) + ")");
        }

        public static DataTable PSgetLesCommandesDG()
        {
            return GestionBoutique.getLesTuplesByRequete("call GetAllCommandesDG", "ToutesLesCommandesDG");
        }


        public static DataTable PSgetLaCommandeById(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("call GetCommandeById(" + Convert.ToString(id) + ")", "ToutesLesCommandes");
        }

        public static DataTable PSgetLesCategories()
        {
            return GestionBoutique.getLesTuplesByRequete("call GetAllCategories", "ToutesLesCategories");
        }
        public static DataTable PSgetDetailsCommande(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("call GetDetailsCommande(" + id + ")", "DetailsCommande");
        }

        public static DataTable PSgetProduitByIdCategorie(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("call GetProduitByIdCategorie(" + Convert.ToString(id) + ")", "ToutLesProduits");
        }

        public static void PSInsertProduitByCommande(int idCommande, int idProduit, int QteCom)
        {
            GestionBoutique.executerRequeteNonQuery("call InsertProduitByCommande(" + Convert.ToString(idCommande) + ", " + Convert.ToString(idProduit) + ", " + Convert.ToString(QteCom) + ")");
        }
        public static int PSGetQteProduitCommande(int idCommande, int idProduit)
        {
            return GestionBoutique.executerRequeteScalar("call GetQteProduitCommande("+Convert.ToString(idCommande)+ ", " + Convert.ToString(idProduit)+")");
        }

        public static void PSChangeQteProduitCommande(  int idCommande, int idProduit, int qte)
        {
            GestionBoutique.executerRequeteNonQuery("call ChangeQteProduitCommande(" + Convert.ToString(qte) + " ," + Convert.ToString(idCommande) + ", " + Convert.ToString(idProduit)+")");
        }

        public static void PSChangeStatutCommande(int idCommande, int boolean)
        {
            GestionBoutique.executerRequeteNonQuery("call ChangeValideCom(" + Convert.ToString(idCommande) + " ," + Convert.ToString(boolean)+")");
        }
    }
}
