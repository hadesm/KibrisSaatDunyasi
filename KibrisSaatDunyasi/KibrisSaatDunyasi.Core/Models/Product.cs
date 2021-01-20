using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.Core.Models
{
  public  class Product
    {
        public string productid { get; set; }
        public string productname { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public string image { get; set; }
        public decimal price { get; set; }
        public string brand { get; set; }

        public Product()
        {
            this.productid = Guid.NewGuid().ToString();
        }
    }
}
