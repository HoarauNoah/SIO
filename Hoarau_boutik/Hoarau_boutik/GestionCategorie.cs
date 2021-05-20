using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Hoarau_boutik
{
    class GestionCategorie
    {
        public static DataTable getAll()
        {
            return GestionBoutique.getLesTuplesByRequete("select * from categorie", "ToutesLesCategories");
        }
        public static DataTable getById(int id)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from categories where idCategorie =" + id,"ToutesLesCategories");
        }
        public static DataTable getByName(string name)
        {
            return GestionBoutique.getLesTuplesByRequete("select * from categories where LibelleCategories like '%"+ name + "%'", "ToutesLesCategories");
        }
    }
}
