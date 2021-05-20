using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hoarau_boutik
{
    class GestionFournisseur
    {
        public static DataTable getAll()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur", "ToutLesFournisseurs");
        }
        public static DataTable getById(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur where idFournisseur = "+ id, "ToutLesFournisseurs");
        }
        public static DataTable getByName(int name)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur where NomFournisseur like '" + name + "%'" ,"ToutLesFournisseurs") ;
        }
        public static DataTable getByCity(int c)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur where VilleFournisseur like ' " + c + "%'", "ToutLesFournisseurs");
        }
        public static DataTable getByCp(int cp)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from fournisseur where CPFournisseur like '" + cp + "%'","ToutLesFournisseurs");
        }
        public static DataTable getName()
        {
            return GestionBoutique.getLesTuplesByRequete("select nomFournisseur from fournisseur", "ToutLesNomsFournisseurs");
        }
    }
}
