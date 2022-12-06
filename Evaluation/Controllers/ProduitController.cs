using DAO.Model;
using Evaluation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evaluation.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class ProduitController : ControllerBase
    {
        private readonly ProduitModel _produitModel;
        public ProduitController(ProduitModel modelProduit)
        {
            _produitModel = modelProduit;
        }
        public ActionResult<IEnumerable<Produit>> GetAllProduits()
        {
            var products = _produitModel.getProducts();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public ActionResult<Produit> GetCommandById(int id)
        {
            var product= _produitModel.getProduct(id);
            return Ok(product);
        }
    }
}
