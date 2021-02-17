using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.Core.Models
{
  public  class Product : BaseEntity
    {
        
        [DisplayName ("Ürün Adı")]
        public string productname { get; set; }
      
        public string catname { get; set; }
        public string descript { get; set; }
        public string img { get; set; }
        public decimal price { get; set; }
        public string brand { get; set; }
        public Boolean Kadın { get; set; }
        public Boolean Erkek { get; set; }
        public Boolean Unisex { get; set; }





    }
}
