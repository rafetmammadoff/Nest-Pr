using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nest.DAL;
using Nest.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nest.Controllers
{
    public class ShopController : Controller
    {
        private readonly NestContext _context;

        public ShopController(NestContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Product(int? id)
        {
            Product? product = _context.Products.Include(p=>p.Tags).ThenInclude(pt=>pt.Tag).FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Compare()
        {
            return View();
        }

    }
}

