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
        
        public AdminController(IRepository<Product> context, IRepository<ProductCat> pcontext)
        {
            this.context = context;
            this.pcontext = pcontext;
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

        public ActionResult CreateProduct()
        {
            Product pro = new Product();
            return View(pro);
        }
        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                return View(product);
            } else 
            {
                context.Insert(product);
                context.Commit();
            }

            return RedirectToAction("Products");
        }
        public ActionResult CreateProductCat()
        {
            ProductCat productCat = new ProductCat();

            return View(productCat);
        }
        [HttpPost]
        public ActionResult CreateProductCat(ProductCat productCat)
        {
            
            
            if (!ModelState.IsValid )
            {
                return View(productCat);
            }
            else
            {
                pcontext.Insert(productCat);
                pcontext.Commit();
                return RedirectToAction("ProductCats");
            }

            
        }
        [ActionName("Delete")]
        public ActionResult PcatDelete(string Id)
        {
            ProductCat procatdel = pcontext.Find(Id);
            if(procatdel == null)
            {
                return HttpNotFound();
            }else
            {
                return View(procatdel);
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult CatConfirmDelete(string Id)
        {
            ProductCat proCatDel = pcontext.Find(Id);
            if (proCatDel == null)
            {
                return HttpNotFound();
            
            }
            else
            {
                pcontext.Delete(Id);
                pcontext.Commit();
            }
            return RedirectToAction("ProductCats");
        }

        [ActionName("Delete")]
        public ActionResult ProDelete(string Id)
        { 
            Product procatdel = context.Find(Id);
            if (procatdel == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(procatdel);
            }
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(string Id)
        {
            Product proCatDel = context.Find(Id);
            if (proCatDel == null)
            {
                return HttpNotFound();

            }
            else
            {
                pcontext.Delete(Id);
                pcontext.Commit();
            }
            return RedirectToAction("Products");
        }
        public ActionResult ProductEdit()
        {
            return View();
        }
        public ActionResult ProductCatEdit()
        {
            return View();
        }
    }
}