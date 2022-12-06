using DAO.Model;
using System.Collections.Generic;

namespace DAO.Service
{
    public interface IDAOProduit
    {
        List<Produit> GetAllProduits();
        Produit GetProduit(int thisid);
    }
}