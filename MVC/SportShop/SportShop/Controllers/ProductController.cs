using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SportShop.DAL;
using SportShop.Entities;
using SportShop.Models;
using SportShop.Repositories;

namespace SportShop.Controllers
{
    public class ProductController : Controller
    {
        //Dipendency injection
        private readonly IProductRepository _repository; 

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            // tests connection
            //using (var db = new SportShopContext())
            //{
            //    var customer = new Customer
            //    {
            //        Email = "test@test"
            //    };
            //    db.Customers.Add(customer);
            //    db.SaveChanges();
            //}

            var items = _repository.Getproducts();

            var model = new ProductGridModel //2
            {
                Items = items,
                Count = items.Count()
            };

            //return View(items);
            return View(model);

        }


        public ActionResult GetProduct(long productId)
        {
            
            var model = _repository.Getproducts();
            return View(model);
        }

        [HttpPost]
        public ActionResult GetProduct(ProductDetailsViewModel model)
        {
            var productItems = _repository.Getproducts();

            return View(productItems);
            //if (model.Price % 4 != 0)
            //{
            //    ModelState.AddModelError(nameof(ProductDetailsViewModel.Price), "zla wartosc");
            //}

            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("List");
            //}
            //return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            var model = new ProductAddViewModel();


            return View(model);
        }

        [HttpPost]
        public ActionResult Add(ProductAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _repository.Save(model);
                return RedirectToAction("List");
            }

            return View(model);
        }



    }

    public class ProductGridModel //2
    {
        public long Count { get; set; }

        public IEnumerable<ProductGridViewModel> Items { get; set; }
    }
}