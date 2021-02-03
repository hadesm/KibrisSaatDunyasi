using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.Core.Models
{
   public class ProductCat
    {
        public string catid { get; set; }
        public string name { get; set; }

        public ProductCat()
        {
            this.catid = Guid.NewGuid().ToString();
        }
    }
}
