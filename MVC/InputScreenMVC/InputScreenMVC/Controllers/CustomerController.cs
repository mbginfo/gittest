using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InputScreenMVC.Models;

namespace InputScreenMVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private List<Customer> Customers = new List<Customer>();

        public CustomerController()
        {
            Customer obj1 = new Customer();
            obj1.Id = 11;
            obj1.CustomerCode = "101";
            obj1.Amount = 11.11;

            Customers.Add(obj1);

            obj1 = new Customer();
            obj1.Id = 22;
            obj1.CustomerCode = "202";
            obj1.Amount = 22.22;

            Customers.Add(obj1);

        }

        //public CustomerController()

        //{
        //    Customer obj1 = new Customer();
        //    obj1.Id = 11;
        //    obj1.CustomerCode = "101";
        //    obj1.Amount = 11.11;

        //    Customers.Add(obj1);

        //    Customer obj2 = new Customer();
        //    obj2.Id = 22;
        //    obj2.CustomerCode = "202";
        //    obj2.Amount = 22.22;

        //    Customers.Add(obj2);

        //}

    public ActionResult FillCustomer()
        {
            return View();
        }
        //[HttpPost]
        public ActionResult DisplayCustomer(int Id)
        {
            Customer objCustomer = Customers[Id];
           return View("DisplayCustomer", objCustomer);
        }
    }
}