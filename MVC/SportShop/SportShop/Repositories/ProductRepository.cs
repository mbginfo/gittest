using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using SportShop.DAL;
using SportShop.Entities;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SportShopContext _context;

        public ProductRepository(SportShopContext context)
        {
            _context = context;
        }
        public IEnumerable<ProductGridViewModel> Getproducts()
        {
            return _context.Products.Select(x => new ProductGridViewModel()
            {
                CategoryName = x.Category.Name,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            }).ToList();
        }

        public ProductGridViewModel Get(long id)
        {
            return _context.Products.Where(p => p.Id == id).Select(p => new ProductGridViewModel
            {
                Description = p.Description,
                Id = p.Id,
                Price = p.Price,
                Name = p.Name

            }).Single();
        }

        public void Add(ProductAddViewModel model)
        {

            var product = new Product()
            {

                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Category = _context.Categories.Single(x => x.Id == model.CategoryId)

            };

            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}