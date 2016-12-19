using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using delapp.Models;
using Microsoft.AspNetCore.Http;

namespace delapp.Controllers
{
    public class CartController : Controller
    {
        DeliveryContext db;
        public CartController(DeliveryContext context)
        {
            db = context;
        }


        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnUrl
            });
        }

        public Cart GetCart()
        {
            Cart cart = null;
            if (cart == null)
            {
                cart = new Cart();
            }
            return cart;
        }
        
        public async Task<IActionResult> AddToCart(int Id, string returnUrl)
        {
            Dish dish = db.Dish
                .FirstOrDefault(b => b.Id == Id);

            if (dish != null)
            {
                GetCart().AddItem(dish, 1);
            }
            
            return RedirectToAction ("Index", new { returnUrl });
        }

        public async Task<IActionResult> RemoveFromCart(int Id, string returnUrl)
        {
            Dish dish = db.Dish
                 .FirstOrDefault(b => b.Id == Id);

            if (dish != null)
            {
                GetCart().RemoveLine(dish);
            }

            return RedirectToAction("Index", new { returnUrl });
        }


        }
    }