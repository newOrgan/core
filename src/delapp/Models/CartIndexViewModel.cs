using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delapp.Models
{
    public class CartIndexViewModel
    {
        public Dish Dish { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public double price { get; set; }
    }
}
