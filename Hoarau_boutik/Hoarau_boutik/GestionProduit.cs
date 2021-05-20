using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hoarau_boutik
{
    class GestionProduit
    {
        public static DataTable getAll()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit", "ToutLesProduits");
        }
        public static DataTable getByPrix(int prix)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where PrixHTProduit =" + prix, "ToutLesProduits");
        }
        public static DataTable getById(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where idProduit =" + id, "ToutLesProduits");
        }
        public static DataTable getByName(string name)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where LibelleProduit like '%" + name + "%'", "ToutLesProduits");
        }
        public static DataTable getByStock(int stock)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where QteStockProduit =" + stock, "ToutLesProduits");
        }
        public static DataTable getByFournisseurId(int idFournisseur)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where idFourn =" + idFournisseur, "ToutLesProduits");
        }
        public static DataTable getByIdCategorie(int idCat)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from produit where idCat =" + idCat, "ToutLesProduits");
        }

        public static DataTable getSelected()
        {
            return GestionBoutique.getLesTuplesByRequete("select idProduit, libelleProduit, prixHTProduit, QteStockProduit, libelleCategorie, nomFournisseur FROM Produit, Fournisseur, Categorie WHERE produit.idFourn = fournisseur.idFournisseur and produit.idCat = categorie.idCategorie ", "ToutLesProduitsDG") ;
        }
        public static int getNbProduit()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "select count(*) from produit";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar()); ;
        }

        public static void add(int id, string libelle, int prix, int qte, int idFouni, int idCat)
        {
            GestionBoutique.maRequete = " Insert into produit Values( " + id + " ,'" + libelle + "'," + prix + "," + qte + "," + idFouni + "," + idCat + ")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
    }
}
