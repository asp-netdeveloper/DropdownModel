using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dropdownworking.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public List<SelectListItem> Listofproducts { get; set; }
    }
}
