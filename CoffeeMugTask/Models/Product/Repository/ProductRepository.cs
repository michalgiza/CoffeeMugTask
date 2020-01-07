using CoffeeMugTask.Models.Product.DTO;
using CoffeeMugTask.Models.Product.Mapper;
using CoffeeMugTask.Models.Product.Mapper.Interface;
using CoffeeMugTask.Models.Product.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Models.Product.Repository
{
    public class ProductRepository : I_ProductRepository
    {
        private readonly ProductContext _context;
        private readonly I_ProductMapper _productMapper;

        public ProductRepository(ProductContext context)
        {
            _context = context;
            _productMapper = new ProductMapper();
        }

        public bool DeleteProduct(int id)
        {
            Product product = _context.Products.Find(id);
            if(product == null)
            {
                return false;
            }

            _context.Products.Remove(product);
            _context.SaveChanges();

            return true;
        }

        public Product GetProduct(int id)
        {
            Product product = _context.Products.Find(id);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products;
        }

        public int SaveProduct(ProductCreateInputModel createProduct)
        {
            Product product = _productMapper.MapProductCreateInputModel(createProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }

        public bool UpdateProduct(ProductUpdateInputModel updateProduct)
        {
            if (_context.Products.Find(updateProduct.Id) == null)
            {
                return false;
            }
            Product product = _productMapper.MapProductUpdateInputModel(updateProduct);

            _context.Entry(product).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }
    }
}
