using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.DAL;
using SportShop.Entities;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class CategoryRepository : ICustomerRepository
    {
        private readonly SportShopContext _dbContext;

        public CustomerRepository(SportShopContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<CustomerGridViewModel> GetCustomer()
        {
            return _dbContext.Customers.Select(p => new CustomerGridViewModel
            {
                Name = p.Name + " " + p.lastName
            });
        }

        public void Save(AddCustomerViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}