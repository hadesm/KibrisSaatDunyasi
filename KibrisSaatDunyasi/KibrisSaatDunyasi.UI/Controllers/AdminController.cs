using KibrisSaatDunyasi.Core.Contracts;
using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KibrisSaatDunyasi.UI.Controllers
{
    public class AdminController : Controller
    {
        IRepository<Product> context;
        IRepository<ProductCat> pcontext;

        public AdminController(IRepository<Product> context, IRepository<ProductCat> productcategories)
        {
            this.context = context;
            this.pcontext = productcategories;
        }
        // GET: Admin
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Products()
        {
            List<Product> product = context.Collection().ToList();
            return View(product);
        }
        public ActionResult ProductCats()
        {
            List<ProductCat> productcat = pcontext.Collection().ToList();
            return View(productcat);
        }
    }
}