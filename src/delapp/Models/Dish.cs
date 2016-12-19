using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delapp.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Anything { get; set; }
        public bool Access { get; set; }
        public double Price { get; set; }
        public string Options { get; set; }

       
    }
}
