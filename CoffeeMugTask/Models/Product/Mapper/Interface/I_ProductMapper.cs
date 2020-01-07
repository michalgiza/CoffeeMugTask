using CoffeeMugTask.Models.Product.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMugTask.Models.Product.Mapper.Interface
{
    public interface I_ProductMapper
    {
        Product MapProductCreateInputModel(ProductCreateInputModel productCreateInputModel);
        Product MapProductUpdateInputModel(ProductUpdateInputModel productUpdateInputModel);
    }
}
