using NLayeredProjectExample.Core.DataAccess;
using NLayeredProjectExample.Entity.ComplexTypes;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredProjectExample.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductCategoryComplexData> GetProductWithCategory();
    }
}
