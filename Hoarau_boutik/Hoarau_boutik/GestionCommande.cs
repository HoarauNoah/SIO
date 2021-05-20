using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Hoarau_boutik
{
    class GestionCommande
    {
        public static DataTable getAll()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from commande", "ToutesLesCommandes");
        }

        public static DataTable getById(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from commande where idCommande = " + id , "ToutesLesCommandes");
        }
        public static DataTable getByDate(string date)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from commande where DateCommande like '%" + date + "%'" , "ToutesLesCommandes");
        }
        public static DataTable getByClientId(int clientId)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from commande where idCli = " + clientId, "ToutesLesCommandes");
        }

        public static DataTable getLesCommandesDG()
        {
            return GestionBoutique.getLesTuplesByRequete("Select  commande.idCommande ,dateCommande , CONCAT(prenomClient , ' ' , nomClient) as Client , sum(prixHTProduit* 0.20* quantiteCom) as PrixTTC  from client, commande , produit , lignedecommande  where client.idClient = commande.idCli and lignedecommande.idCommande = commande.idCommande and lignedecommande.idProduit = produit.idProduit group by idCommande" , "ToutesLesCommandesDG");
        }

        public static int getNbCommandes()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "select count(*) from commande";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar()); ;
        }

        public static void add(int id, string date, int idClient)
        {
            GestionBoutique.maRequete = "Insert into commande Values( " + id + " ,'" + date + "'," + idClient +")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static void del(int id)
        {
            GestionBoutique.maRequete = "Delete from commande Where idCommande = " + id;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void change(int id, string date, int idClient)
        {
            GestionBoutique.maRequete = "update commande set DateCommande= '" + date + "', idCli = '" + idClient + "' Where idCommande = " + id;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static DataTable getDetailsCommande(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("SELECT produit.idproduit, libelleproduit, prixhtproduit, quantitecom, (prixhtproduit * quantitecom) AS MontantLigneHT FROM produit, lignedecommande WHERE produit.idProduit = lignedecommande.idProduit AND idcommande = " + id, "laCommande");
        }

        public static void addProduit(int idCommande,int idProduit, int QteCom)
        {
            GestionBoutique.maRequete = "INSERT INTO lignedecommande VALUES(" + idCommande + ", " + idProduit + ", " + QteCom + ")";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }

        public static void addQteProduit(int idCommande, int idProduit, int QteCom)
        {
            GestionBoutique.maRequete = "UPDATE `lignedecommande` SET `QuantiteCom` = '"+ QteCom +"' WHERE `lignedecommande`.`idCommande` = "+ idCommande+" AND `lignedecommande`.`idProduit` = "+ idProduit;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery(); 
        }
        

        public static int getQteProduitCommande (int idCommande, int idProduit)
        {
            string maRequete = "SELECT QuantiteCom From lignedecommande where idCommande = " + idCommande + " and idProduit = "+ idProduit;
            GestionBoutique.maCommandeSpecialRequete.CommandText = maRequete;
            int qte = Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
            return qte;
        }

        public static void changeQteProduit (int idCommande, int idProduit, int qte)
        {
            GestionBoutique.maRequete = "update lignedecommande set QuantiteCom = " + qte + " Where idCommande = " + idCommande + " and idProduit = " + idProduit;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
    }
}
