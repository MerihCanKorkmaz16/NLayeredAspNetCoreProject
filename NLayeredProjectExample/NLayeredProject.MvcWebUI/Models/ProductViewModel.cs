using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredProjectExample.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}
