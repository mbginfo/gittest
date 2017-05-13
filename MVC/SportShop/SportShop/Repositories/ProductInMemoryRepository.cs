using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class ProductInMemoryRepository : IProductRepository
    {
        public IEnumerable<ProductGridViewModel> Getproducts()
        {
            return new[]
            {
                new ProductGridViewModel
                {
                    Id = 1,
                    Name = "Produkt pierwszy",
                    Price = 10
                },

                new ProductGridViewModel
                {
                    Id = 2,
                    Name = "Produkt drugi",
                    Price = 20
                },

                new ProductGridViewModel
                {
                    Id = 3,
                    Name = "Produkt Trzeci",
                    Price = 30
                },
            };

        }

        public ProductGridViewModel Get(long id)
        {
            return new ProductGridViewModel()
            {
                Id = 1,
                Name = "Nowy",
                Price = 250
            };
        }

        public void Add(ProductAddViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}