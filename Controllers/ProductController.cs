using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductOrderCRUD.Models;
using ProductOrderCRUD.Data;

namespace ProductOrderCRUD.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductOrderContext _context;

        public ProductController(ProductOrderContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // var product = await _context.product;
            // if(product == null){
            //     return NotFound();
            // }
            return View();
        }
        public IActionResult create()
        {
            // var product = await _context.product;
            // if(product == null){
            //     return NotFound();
            // }
            return View("create");
        }
    }
}
