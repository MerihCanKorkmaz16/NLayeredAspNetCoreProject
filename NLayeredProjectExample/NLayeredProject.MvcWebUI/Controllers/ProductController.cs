﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayeredProjectExample.Business.Abstract;
using NLayeredProjectExample.Entity.Concrete;
using NLayeredProjectExample.MvcWebUI.Models;

namespace NLayeredProjectExample.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        private IProductImageService _productImageService;
        //root klosörünü kullanmak için
        private IHostingEnvironment _env;
        public ProductController(IProductService productService, ICategoryService categoryService, IProductImageService productImageService, IHostingEnvironment env)
        {
            _productService = productService;
            _categoryService = categoryService;
            _productImageService = productImageService;
            _env = env;
    }

        public IActionResult GetProducts()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = _productService.GetProductWithCategory(),
                Categories = LoadCategories()
            };
            return View(productViewModel);
        }
        private List<SelectListItem> LoadCategories()
        {
            List<SelectListItem> categories = (from category in _categoryService.GetList()
                                               select new SelectListItem
                                               {
                                                   Value = category.Id.ToString(),
                                                   Text = category.Name
                                               }
                                               ).ToList();
            return categories;
        }
        public IActionResult GetProductDetail(int id)
        {
            if (id > 0)
            {
                var productIsValid = _productService.GetById(id);
                var productImages = _productImageService.GetListProductId(id);
                var productViewModel = new ProductViewModel
                {
                    Product = productIsValid,
                    ProductImages = productImages,
                    Categories = LoadCategories()
                };
                return View(productViewModel);
            }
            return RedirectToAction("GetProducts");
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
                    CategoryId = productViewModel.Product.CategoryId,
                    Explanation = productViewModel.Product.Explanation,
                    Height = productViewModel.Product.Height,
                    Name = productViewModel.Product.Name,
                    Weight = productViewModel.Product.Weight,
                    Width = productViewModel.Product.Width
                };
                try
                {
                    var addedProduct = _productService.Add(productForAdd);
                    if (productViewModel.FormFiles != null)
                    {
                        foreach (var image in productViewModel.FormFiles)
                        {
                            var uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                            var filePath = Path.DirectorySeparatorChar.ToString() + "ProductImages" + Path.DirectorySeparatorChar.ToString() + uniqueFileName;
                            var upLoadsFolder = Path.Combine(_env.WebRootPath, "ProductImages");
                            var filePathForCopy = Path.Combine(upLoadsFolder, uniqueFileName);
                            image.CopyTo(new FileStream(filePathForCopy, FileMode.Create));

                            var productImageForAdd = new ProductImage
                            {
                                AddedBy = "merih",
                                AddedDate = DateTime.Now,
                                ProductId = addedProduct.Id,
                                FileName = uniqueFileName,
                                FilePath = filePath
                            };
                            _productImageService.Add(productImageForAdd);
                        }
                    }
                    return RedirectToAction("GetProducts");
                }
                catch (Exception)
                {
                    return RedirectToAction("GetProducts");
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

        public JsonResult Delete(int id)
        {
            if (id > 0)
            {
                var productIsValid = _productService.GetById(id);
                if (productIsValid == null)
                {
                    return Json(0);
                }
                _productService.Delete(productIsValid);
                return Json(1);
            }
            return Json(0);
        }

    }
}
