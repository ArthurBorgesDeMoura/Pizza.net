using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pizzaria.Pages.Domain.Models
{
    public class PizzasModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public bool Cheese { get; set; } 
        public bool Mushroom { get; set; }
        public bool Pepperoni { get; set; }
        public bool Pinaple { get; set; }
        public bool Sauce { get; set; }
        public bool Tomato { get; set; }
    }
}
