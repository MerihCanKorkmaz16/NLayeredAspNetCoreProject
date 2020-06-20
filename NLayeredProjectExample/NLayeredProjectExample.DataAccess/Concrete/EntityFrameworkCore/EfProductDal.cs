using NLayeredProjectExample.Core.DataAccess.EntityFrameworkCore;
using NLayeredProjectExample.DataAccess.Abstract;
using NLayeredProjectExample.Entity.ComplexTypes;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NLayeredProjectExample.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NLayeredProjectDbContext>, IProductDal
    {
        public List<ProductCategoryComplexData> GetProductWithCategory()
        {
            using (var context = new NLayeredProjectDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories on p.CategoryId equals c.Id
                             select new ProductCategoryComplexData
                             {
                                 CategoryName = c.Name,
                                 Height = p.Height,
                                 ProductId = p.Id,
                                 ProductName = p.Name,
                                 Weight = p.Weight,
                                 Width = p.Width
                             };
                return result.ToList();
            }
        }
    }
}
