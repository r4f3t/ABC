using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ABC.Northwind.Business.Abstract;
using ABC.Northwind.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ABC.Northwind.MVCWebUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService productService;
        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }
        public IActionResult Index()
        {

            ProductListViewModel vm = new ProductListViewModel()
            {
                Products = productService.GetAll()
            };
            return View(vm);
        }
    }
}