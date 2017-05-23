using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Entities;
using SportShop.Models;

namespace SportShop.Repositories
{
    public interface ICustomerRepository
    {
        IEnumerable <CustomerGridViewModel> GetCustomer();
        void Save(AddCustomerViewModel model);
        EditCustomerViewModel Get(long Id);
        void Update(EditCustomerViewModel model);
        void Delete(long id);
    }
}