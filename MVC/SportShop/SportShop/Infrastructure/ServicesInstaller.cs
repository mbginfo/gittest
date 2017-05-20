using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Core.Configuration;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using SportShop.DAL;
using SportShop.Repositories;

namespace SportShop.Infrastructure
{
    public class ServicesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Component.For<IProductRepository>
            //    ().ImplementedBy<ProductInMemoryRepository>());

            container.Register(Component.For<IProductRepository>
                ().ImplementedBy<ProductRepository>());

            container.Register(Component.For<SportShopContext>());

            container.Register(Component.For<ICustomerRepository>
                ().ImplementedBy<CustomerRepository>());
        }

     }
}