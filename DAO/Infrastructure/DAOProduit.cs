using DAO.Model;
using DAO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Infrastructure
{
    public class DAOProduit :  IDAOProduit
    {
        private MyInData _db=new MyInData();
        public Produit GetProduit(int thisid)
        {
            Produit produit = _db._lstProduit.Where(x => x.id == thisid).FirstOrDefault();
            if (produit == null)
                throw new ArgumentException("Produit n'existe pas");
            return produit;
        }
        public List<Produit> GetAllProduits()
        {
            if (_db._lstProduit == null)
                throw new ArgumentNullException("No produits");
            return _db._lstProduit;

        }
    }
}
