using CoffeeMugTask.Models.Product.DTO;
using CoffeeMugTask.Models.Product.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Controllers.Product
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly I_ProductRepository _productRepository;

        public ProductController(I_ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<CoffeeMugTask.Models.Product.Product> Get()
        {
            return _productRepository.GetProducts();
        }

        [HttpGet("{id}")]
        public CoffeeMugTask.Models.Product.Product Get(int id)
        {
            return _productRepository.GetProduct(id);
        }

        [HttpPost]
        public int Guid_Post([FromBody] ProductCreateInputModel model)
        {
            return _productRepository.SaveProduct(model);
        }

        [HttpPost]
        public void Put([FromBody] ProductUpdateInputModel model)
        {
            _productRepository.UpdateProduct(model);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _productRepository.DeleteProduct(id);
        }


    }
}
