using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Hoarau_boutik
{
    class GestionClient
    {
        public static DataTable getAll()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client", "ToutLesClients");
        }

        public static DataTable getById(int idClient)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where idClient =" + idClient, "ToutLesClients");
        }
        public static DataTable getByFirstName(string prenomClient)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where PrenomClient like '%" + prenomClient + "%'", "ToutLesClients");
        }
        public static DataTable getByName(string nomClient)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where NomClient like '%" + nomClient +"%'", "ToutLesClients");
        }
        public static DataTable getByAdress(string adClient)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where AdRueClient like '%" + adClient + "%'", "ToutLesClients");
        }
        public static DataTable getByCodePostal(string cp)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where AdCpClient like '%" + cp + "%'", "ToutLesClients");
        }
        public static DataTable getByVille(string ville)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where AdVilleClient like '%" + ville + "%'", "ToutLesClients");
        }
        public static int getNbClient()
        {
            GestionBoutique.maCommandeSpecialRequete.CommandText = "select count(*) from client";
            return Convert.ToInt32(GestionBoutique.maCommandeSpecialRequete.ExecuteScalar());
        }
        public static void Clear()
        {
            GestionBoutique.monJeuDeDonnees.Clear();
        }
        public static void add(int id, string nom, string prenom, string adresse, string codePostal, string ville )
        {
            GestionBoutique.maRequete = " Insert into client Values( " + id + " ,'" + nom + "','" + prenom + "','" + adresse + "','" + codePostal + "','" + ville + "')";
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static DataTable search(string search)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from client where NomClient like '% " + search + "%' or PrenomClient like '% " + search + "%' or AdRueClient like '% " + search + "%' or AdCpClient like '% " + search + "%' or AdVilleClient like '% " + search + "%'", "ToutLesClients");
        }
        public static void del(int id)
        {
            GestionBoutique.maRequete = "Delete from client Where idClient = " + id ;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
        public static void change(int id, string nom, string prenom, string adresse, string codePostal, string ville)
        {
            GestionBoutique.maRequete = "update client set NomClient= '" + nom + "', PrenomClient = '"+ prenom +"', AdRueClient = '"+ adresse+ "', AdCpClient ='"+codePostal+"', AdVilleClient='" + ville+"'" + " Where idClient = " + id;
            GestionBoutique.maCommandeSpecialRequete.CommandText = GestionBoutique.maRequete;
            GestionBoutique.maCommandeSpecialRequete.ExecuteNonQuery();
        }
    }
}
