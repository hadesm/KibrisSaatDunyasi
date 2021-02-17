using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KibrisSaatDunyasi.Core.Contracts;
using KibrisSaatDunyasi.Core.Models;
using KibrisSaatDunyasi.DataAccess.InMemory;

namespace KibrisSaatDunyasi.UI.Controllers
{
    public class ProductManagerController : Controller
    {
        IRepository<Product> context;
        IRepository<ProductCat> productcategories;

        public ProductManagerController(IRepository<Product> context, IRepository<ProductCat> productcategories)
        {
            this.context =context;
            this.productcategories = productcategories;
        }



        // GET: ProductManager
        public ActionResult Index()
        {
            List<Product> products = context.Collection().ToList();
            return View(products);
        }
        
        public ActionResult create()
        {
            Product product = new Product();
            return View(product);
        }
        [HttpPost]      
        public ActionResult create(Product product)
        {
            if (ModelState.IsValid)
            {
                return View(product);
            }
            else
            {
                context.Insert(product);
                context.Commit();
            }
            return RedirectToAction("Index");

        }
    }
}