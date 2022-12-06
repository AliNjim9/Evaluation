using DAO.Infrastructure;
using DAO.Model;
using DAO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.Models
{
    public class ProduitModel
    {
        private IDAOProduit _DBproduit ;
        public ProduitModel(IDAOProduit dbproduit)
        {
            _DBproduit = dbproduit;
        }
        public Produit getProduct(int id)
        {
           return _DBproduit.GetProduit(id);
           
        }
        public List<Produit> getProducts()
        {
            return _DBproduit.GetAllProduits();
          
           
        }
    }
}
