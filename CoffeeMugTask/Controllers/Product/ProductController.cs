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

    }
}
