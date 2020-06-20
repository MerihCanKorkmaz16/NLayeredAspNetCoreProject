using NLayeredProjectExample.Business.Abstract;
using NLayeredProjectExample.DataAccess.Abstract;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayeredProjectExample.Business.Concrete.Managers
{
    public class ProductImageManager : IProductImageService
    {
        private IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public ProductImage Add(ProductImage productImage)
        {
           return  _productImageDal.Add(productImage);
        }

        public void Delete(ProductImage productImage)
        {
            _productImageDal.Delete(productImage);
        }

        public ProductImage GetById(int id)
        {
            return _productImageDal.Get(p=>p.Id == id);
        }

        public List<ProductImage> GetList()
        {
            return _productImageDal.GetAll();
        }

        public List<ProductImage> GetListProductId(int productId)
        {
            return _productImageDal.GetAll(p=>p.ProductId == productId);
        }

        public ProductImage Update(ProductImage productImage)
        {
            return _productImageDal.Update(productImage);
        }
    }
}
