using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NLayeredProjectExample.Business.Abstract;
using NLayeredProjectExample.Entity.Concrete;
using NLayeredProjectExample.MvcWebUI.Models;

namespace NLayeredProjectExample.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult GetProducts()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetList()
            };
            return View(productViewModel);
        }

        public IActionResult Add(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productIsValid = _productService.GetByName(productViewModel.Product.Name);
                if (productIsValid != null)
                {
                    return RedirectToAction("GetProducts");
                }

                var productForAdd = new Product
                {
                    AddedDate = DateTime.Now,
                    AddedBy = "Merih Can Korkmaz",
                    CategoryId = 1,
                    Explanation = productViewModel.Product.Explanation,
                    Height = productViewModel.Product.Height,
                    Name = productViewModel.Product.Name,
                    Weight = productViewModel.Product.Weight,
                    Width = productViewModel.Product.Width
                };
                try
                {
                    _productService.Add(productForAdd);
                    return RedirectToAction("GetProducts");
                }
                catch (Exception)
                {return RedirectToAction("GetProducts");
                }
            }
            return RedirectToAction("GetProducts");
        }

        public JsonResult Edit(int id)
        {
            if (id > 0)
            {
                var result = _productService.GetById(id);

                return Json(result);
            }
            return Json(0);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel productViewModel)
        {
            if (ModelState.IsValid)
            {
                var productIsValid = _productService.GetById(productViewModel.Product.Id);
                if (productIsValid == null)
                {
                    return RedirectToAction("GetProducts");
                }
                var productForUpdate = new Product
                {
                    AddedBy = productIsValid.AddedBy,
                    AddedDate = productIsValid.AddedDate,
                    CategoryId = productViewModel.Product.CategoryId,
                    Explanation = productViewModel.Product.Explanation,
                    Height = productViewModel.Product.Height,
                    Name = productViewModel.Product.Name,
                    Weight = productViewModel.Product.Weight,
                    Width = productViewModel.Product.Width,
                    Id = productIsValid.Id
                };
                try
                {
                    _productService.Update(productForUpdate);
                    return RedirectToAction("GetProducts");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetProducts");
                }
            }
            return RedirectToAction("GetProducts");
        }

    }
}
