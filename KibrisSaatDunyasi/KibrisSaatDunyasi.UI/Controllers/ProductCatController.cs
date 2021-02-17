using KibrisSaatDunyasi.Core.Contracts;
using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KibrisSaatDunyasi.UI.Controllers
{
    public class ProductCatController : Controller
    {
        IRepository<ProductCat> context;

        public ProductCatController(IRepository<ProductCat> context)
        {
            this.context = context;
        }
        // GET: ProductCat
        public ActionResult Index()
        {
            List<ProductCat> productcat = context.Collection().ToList();
            return View();
        }
        public ActionResult Create()
        {
            ProductCat procat = new ProductCat();
            return View(procat);
        }
        [HttpPost]
        public ActionResult Create(ProductCat pc)
        {
            if (ModelState.IsValid)
            {
                return View(pc);
            }else
            {
                context.Insert(pc);
                context.Commit();
            }
            return RedirectToAction("Index");

        }

    }
}