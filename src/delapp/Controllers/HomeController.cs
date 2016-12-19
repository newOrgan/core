using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using delapp.Models;
using Microsoft.EntityFrameworkCore;
namespace delapp.Controllers
{
    public class HomeController : Controller
    {
        DeliveryContext db;
        public HomeController(DeliveryContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        ///////Метод для суши
        
        public IActionResult Restaurants(string id)
        {
            ViewBag.Rest = id;
            return View(db.Restaurants.ToList());
        }
        public IActionResult Dishes(string id)
        {
            ViewBag.Dish = id;
            return View(db.Dish.ToList());
        }
        public async Task<IActionResult> OrderIndex()
        {
            return View(await db.Orders.ToListAsync());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();
            return RedirectToAction("OrderIndex");
        } 
    }
}
