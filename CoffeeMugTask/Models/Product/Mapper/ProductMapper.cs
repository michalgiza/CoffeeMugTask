using CoffeeMugTask.Models.Product.DTO;
using CoffeeMugTask.Models.Product.Mapper.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Models.Product.Mapper
{
    public class ProductMapper : I_ProductMapper
    {
        public Product MapProductCreateInputModel(ProductCreateInputModel productCreateInputModel)
        {
            Product product = new Product()
            {
                Id = productCreateInputModel.Id,
                Name = productCreateInputModel.Name,
                Price = productCreateInputModel.Price
            };
            return product;
        }

        public Product MapProductUpdateInputModel(ProductUpdateInputModel productUpdateInputModel)
        {
            Product product = new Product()
            {
                Id = productUpdateInputModel.Id,
                Name = productUpdateInputModel.Name,
                Price = productUpdateInputModel.Price
            };
            return product;
        }
    }
}
