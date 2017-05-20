using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportShop.Models;

namespace SportShop.Repositories
{
    public class CustomerInMemoryRepository : ICustomerRepository
    

    {
       public IEnumerable<CustomerGridViewModel> GetCustomer()
    {
        return new[]
        {
            new CustomerGridViewModel
            {
                Name = "Pierwszy"
            }
        };

    }

        public void Save(AddCustomerViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}