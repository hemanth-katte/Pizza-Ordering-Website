using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.Cheese) PizzaPrice += 39;
            if (Pizza.TomatoSauce) PizzaPrice += 9;
            if (Pizza.Paneer) PizzaPrice += 29;
            if (Pizza.Onion) PizzaPrice += 9;
            if (Pizza.Capcicum) PizzaPrice += 19;
            if (Pizza.Corn) PizzaPrice += 19;
            if (Pizza.Olives) PizzaPrice += 39;
            if (Pizza.Jalapenos) PizzaPrice += 29;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
