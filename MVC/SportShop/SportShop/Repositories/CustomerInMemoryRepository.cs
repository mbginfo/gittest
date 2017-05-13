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
                Name = "Klient pierwszy",
            },

            new CustomerGridViewModel

            {
                Name = "Klient drugi",
            },

            new CustomerGridViewModel

            {
                Name = "Klient Trzeci",
            },
        };

    }
    }
}