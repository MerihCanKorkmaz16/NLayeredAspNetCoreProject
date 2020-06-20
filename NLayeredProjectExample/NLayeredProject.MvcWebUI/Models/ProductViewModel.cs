using Microsoft.AspNetCore.Mvc.Rendering;
using NLayeredProjectExample.Entity.ComplexTypes;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredProjectExample.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<ProductCategoryComplexData> Products { get; set; }
        public Product Product { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
