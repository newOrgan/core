using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace delapp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Sushi { get; set; }
        public string Pizza { get; set; }
        public string Fastfood { get; set; }
        public string Hotdish { get; set; }
        public string Salad { get; set; }
        public string Other { get; set; }
    }
}
