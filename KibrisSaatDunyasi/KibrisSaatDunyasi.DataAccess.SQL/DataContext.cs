﻿using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
        :base ("DefaultConnection"){
            }


        public DbSet<Product> Productss { get; set; }
        public DbSet<ProductCat> ProductCats { get; set; }
    }
}