﻿using NLayeredProjectExample.Business.Abstract;
using NLayeredProjectExample.DataAccess.Abstract;
using NLayeredProjectExample.Entity.ComplexTypes;
using NLayeredProjectExample.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayeredProjectExample.Business.Concrete.Managers
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public async Task<Product> AddAsync(Product product)
        {
            return await _productDal.AddAsync(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p=>p.Id == id);
        }

        public Product GetByName(string name)
        {
            return _productDal.Get(d=> d.Name == name);
        }

        public List<Product> GetList()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetListByCategoryId(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId == categoryId);
        }

        public List<ProductCategoryComplexData> GetProductWithCategory()
        {
            return _productDal.GetProductWithCategory();
        }

        public Product Update(Product product)
        {
            return _productDal.Update(product);
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            return await _productDal.UpdateAsync(product);
        }
    }
}
