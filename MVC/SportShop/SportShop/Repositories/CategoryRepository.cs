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

        public CategoryRepository(SportShopContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<CustomerGridViewModel> GetCustomer()
        {
            return _dbContext.Customers.Select(p => new CustomerGridViewModel
            {
                Name = p.Name + " " + p.lastName,
                Id = p.Id
            });
        }

        public void Save(AddCustomerViewModel model)
        {
            throw new NotImplementedException();
        }

        public EditCustomerViewModel Get(long Id)
        {
            throw new NotImplementedException();
        }

        public void Update(EditCustomerViewModel model)
        {
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}