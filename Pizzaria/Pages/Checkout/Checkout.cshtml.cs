using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Pizzaria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {

        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public bool Cheese { get; set; }
        public bool Pinaple { get; set; }
        public bool Mushroom { get; set; }
        public bool Sauce { get; set; }
        public bool Pepperoni { get; set; }
        public bool Tomato { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {

            return RedirectToPage("/Checkout/ThankYou");
        }
        
    }
}
