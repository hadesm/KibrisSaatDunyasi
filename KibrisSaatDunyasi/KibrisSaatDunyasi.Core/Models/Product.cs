using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.Core.Models
{
  public  class Product
    {
        public string productid { get; set; }
        [DisplayName ("Ürün Adı")]
        public string productname { get; set; }
        public string catid { get; set; }
        public string descript { get; set; }
        public string img { get; set; }
        public decimal price { get; set; }
        public string brand { get; set; }
        public Boolean Kadın { get; set; }
        public Boolean Erkek { get; set; }
        public Boolean Unisex { get; set; }
      

        public Product()
        {
            this.productid = Guid.NewGuid().ToString();
        }
    }
}
