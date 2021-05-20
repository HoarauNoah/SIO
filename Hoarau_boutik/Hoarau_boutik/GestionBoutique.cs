using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hoarau_boutik
{
    class GestionBoutique
    {
        #region champs Statiques

        public static MySqlConnection maConnexion = new MySqlConnection();
        public static MySqlCommand maCommandeSpecialRequete = new MySqlCommand();
        public static MySqlDataAdapter monRemplisseur = new MySqlDataAdapter();
        public static DataSet monJeuDeDonnees = new DataSet();
        public static string maRequete;
        public static string maChaine;
        #endregion

        #region méthodes statiques
        public static void seConnecter()
        {
            if (maConnexion.State == ConnectionState.Closed)
            {
                maConnexion.ConnectionString = maChaine;
                maConnexion.Open();
                monJeuDeDonnees = new DataSet("dsPPE2");
                monJeuDeDonnees.Clear();
                maCommandeSpecialRequete.CommandType = CommandType.Text;
                maCommandeSpecialRequete.Connection = maConnexion;
            }
        }
        public static DataTable getLesTuplesByRequete(string requete, string maDataTable)
        {
            GestionBoutique.seConnecter();
            GestionBoutique.maRequete = requete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.monRemplisseur.SelectCommand = GestionBoutique.maCommandeSpecialRequete;
            GestionBoutique.monRemplisseur.Fill(GestionBoutique.monJeuDeDonnees, maDataTable);

            return GestionBoutique.monJeuDeDonnees.Tables[maDataTable];
        }

        public static void executerRequeteNonQuery(string requete)
        {
            GestionBoutique.maRequete = requete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static int executerRequeteScalar(string requete)
        {
            GestionBoutique.maRequete = requete;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
        public static DataTable getLesCategories()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from categorie", "ToutesLesCategories");
        }
        public static DataTable getLesFournisseurs()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur", "ToutLesFourniseurs");
        }
        public static DataTable getLesProduits()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit", "ToutLesProduits");
        }
        public static DataTable getLesCommandes()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from commande", "ToutesLesCommandes");
        }
        public static DataTable getLesLignesCommandes()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from lignedecommande", "ToutesLesLignesDeCommandes");
        }
        public static DataTable getLesProduitsByCategorie(int idCategorie)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit WHERE idCat = " + idCategorie, "ToutLesProduits");
        }
        public static int genererClePrimaire(string nomcle, string nomtable)
        {
            int cle;
            maRequete = "SELECT Max(" + nomcle + ") FROM " + nomtable;
            GestionBoutique.maCommandeSpecialRequete.CommandText = maRequete;
            cle = Convert.ToInt32( GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return cle + 1;
        }

        #endregion
    }

}
