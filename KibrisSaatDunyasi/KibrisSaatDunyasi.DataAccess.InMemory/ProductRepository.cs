﻿using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.DataAccess.InMemory
{
   public class ProductRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Product> products;

        public ProductRepository()
        {
            products = cache["products"] as List<Product>;

            if(products == null)
            {
                products = new List<Product>();
            }
        }
        public void Commit()
        {
            cache["products"] = products;
        }
        public void Insert(Product p)
        {
            products.Add(p);
        }
        public void Update(Product product)
        {
            Product productToUpdate = products.Find(p => p.productid == product.productid);
            if(productToUpdate != null)
            {
                productToUpdate = product;
            }
            else
            {
                throw new Exception("Ürün bulunamadı");
            }
        }
        public Product Find(string id)
        {
            Product product = products.Find(p => p.productid == id);
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
            Product productToDelete = products.Find(p => p.productid == id);
            if (productToDelete != null)
            {
                products.Remove(productToDelete);
            }
            else
            {
                throw new Exception("Ürün bulunamadı");
            }
        }
    }
}