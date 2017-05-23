using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using SportShop.DAL;
using SportShop.Entities;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class CustomerRepository: ICustomerRepository
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
                Name = p.Name + " " + p.lastName,
                Id = p.Id
            });
        }

        public void Save(AddCustomerViewModel model)
        {
            var customer = new Customer
            {
                Name = model.Name,
                Email = model.Email,
                lastName = model.LastName,
                Phone = model.Phone,
                Sex = model.Sex
            };
            _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
        }

        public EditCustomerViewModel Get(long id)
        {
            return _dbContext.Customers.Where(x => x.Id == id)
                .Select(x => new EditCustomerViewModel
                {
                    Id = id,
                    LastName = x.lastName,
                    Name = x.Name,
                    Phone = x.Phone
                }).Single();
        }

        public void Update(EditCustomerViewModel model)
        {
            var customer = _dbContext.Customers.Single(x => x.Id == model.Id);

            customer.lastName = model.LastName;
            customer.Name = model.Name;
            customer.Phone = model.Phone;

            _dbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            var customer = _dbContext.Customers.Where(x => x.Id == id).Single();
            _dbContext.Customers.Remove(customer);
            _dbContext.SaveChanges();

        }

    }
}