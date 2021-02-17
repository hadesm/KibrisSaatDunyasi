using KibrisSaatDunyasi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KibrisSaatDunyasi.Core.ViewModels
{
    class ProductManagerViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<ProductCat> ProductCats { get; set; }
    }
}
