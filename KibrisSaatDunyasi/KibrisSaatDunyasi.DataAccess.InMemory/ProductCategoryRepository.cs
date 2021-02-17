using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.DataAccess.InMemory
{
    class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCat> products;

        public ProductCategoryRepository()
        {
            products = cache["products"] as List<ProductCat>;

            if (products == null)
            {
                products = new List<ProductCat>();
            }
        }



        public void Commit()
        {
            cache["products"] = products;
        }
        public void Insert(ProductCat p)
        {
            products.Add(p);
        }
        public void Update(ProductCat product)
        {
            ProductCat productToUpdate = products.Find(p => p.Id == product.Id);
            if (productToUpdate != null)
            {
                productToUpdate = product;
            }
            else
            {
                throw new Exception("Ürün bulunamadı");
            }
        }
        public ProductCat Find(string id)
        {
            ProductCat product = products.Find(p => p.Id == id);
            if (product != null)
            {
                return product;
            }
            else
            {
                throw new Exception("Ürün bulunamadı");
            }
        }

        public void Delete(string id)
        {
            ProductCat productToDelete = products.Find(p => p.Id == id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Ürün bulunamadı");
            }
        }
        public IQueryable<ProductCat> Collection()
        {
            return products.AsQueryable();
        }
    }
}
