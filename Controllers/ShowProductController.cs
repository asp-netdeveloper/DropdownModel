using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dropdownworking.Models;
using Dropdownworking.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dropdownworking.Controllers
{
    public class ShowProductController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ShowProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var productList = (from p in _appDbContext.Product
                               select new SelectListItem()
                               {
                                   Text = p.Name,
                                   Value = p.ProductId.ToString(),
                               }).ToList();

            productList.Insert(0, new SelectListItem()
            {
                Text = "Select",
                Value = string.Empty,
            });

            ProductViewModel productViewModel = new ProductViewModel()
            {
                Listofproducts = productList
            };

            //ProductViewModel productViewModel = new ProductViewModel();
            //productViewModel.Listofproducts = productsList;

            return View(productViewModel);
        }
    }
}
