using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductGridViewModel> Getproducts();

        ProductGridViewModel Get(long id);

        void Add(ProductAddViewModel model);
    }
}