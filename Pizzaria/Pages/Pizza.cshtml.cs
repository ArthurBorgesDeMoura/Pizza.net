using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Pages.Domain.Models;

namespace Pizzaria.Pages
{
    public class PizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; } = new PizzasModel();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, Pizza.PizzaPrice, Pizza.Cheese, Pizza.Sauce, 
                                                             Pizza.Pinaple, Pizza.Tomato, Pizza.Mushroom, Pizza.Pepperoni});
        }
    }
}
