using NLayeredProjectExample.Core.DataAccess.EntityFrameworkCore;
using NLayeredProjectExample.DataAccess.Abstract;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredProjectExample.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NLayeredProjectDbContext>,IProductDal
    {
    }
}
