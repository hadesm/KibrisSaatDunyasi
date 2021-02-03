using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KibrisSaatDunyasi.Core.Models;
using KibrisSaatDunyasi.DataAccess.InMemory;

namespace KibrisSaatDunyasi.UI.Controllers
{
    public class ProductManagerController : Controller
    {
        ProductRepository context;

        public ProductManagerController()
        {
            context = new ProductRepository();
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