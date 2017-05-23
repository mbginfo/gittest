using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportShop.Entities;
using SportShop.Models;
using SportShop.Repositories;

namespace SportShop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        private readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CustomerList()
        {
            var customerItems = _repository.GetCustomer();

            
            return View(customerItems);

        }

        //public ActionResult GetCustomer(long Name)
        //{

        //    var model = _repository.Get(Name);
        //    return View(model);
        //}

        [HttpGet]
        public ActionResult Add()
        {
            var model = new AddCustomerViewModel();

                return View(model);
        }

        [HttpPost]
        public ActionResult Add(AddCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(model);
                return RedirectToAction("CustomerList");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(long id)
        {
            var model = _repository.Get(id);
            
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(EditCustomerViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                return RedirectToAction("CustomerList");
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Delete (long id)
        {
            _repository.Delete(id);
           
            return RedirectToAction("CustomerList");

        }


    }

    public class CustomerGridModel
    {
        public long Count { get; set; }

        public IEnumerable<CustomerGridViewModel> Items { get; set; }
    }
}