using DAO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Infrastructure
{
    public class MyInData
    {
        public List<Produit> _lstProduit;
        public MyInData()
        {
            _lstProduit = new List<Produit>();
            _lstProduit.Add(new Produit { id = 1, label = "Article1", quantite = "6" });
            _lstProduit.Add(new Produit { id = 2, label = "Article2", quantite = "22" });
            _lstProduit.Add(new Produit { id = 3, label = "Article3", quantite = "1" });
            _lstProduit.Add(new Produit { id = 4, label = "Article4", quantite = "19" });
            _lstProduit.Add(new Produit { id = 5, label = "Article5", quantite = "3" });
            _lstProduit.Add(new Produit { id = 6, label = "Article6", quantite = "8" });
            _lstProduit.Add(new Produit { id = 7, label = "Article7", quantite = "3" });
            _lstProduit.Add(new Produit { id = 8, label = "Article8", quantite = "12" });
            _lstProduit.Add(new Produit { id = 9, label = "Article9", quantite = "1" });
            _lstProduit.Add(new Produit { id = 10, label = "Article10", quantite = "2" });
        }
    }
}
