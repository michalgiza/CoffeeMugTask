using CoffeeMugTask.Models.Product.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Models.Product.Repository.Interface
{
    public interface I_ProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        int SaveProduct(ProductCreateInputModel createProduct);

        bool UpdateProduct(ProductUpdateInputModel updateProduct);

        bool DeleteProduct(int id);

    }
}
