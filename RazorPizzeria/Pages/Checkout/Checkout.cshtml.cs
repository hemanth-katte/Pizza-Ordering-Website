using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet=true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }

        public float PizzaPrice { get; set; }

        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (String.IsNullOrEmpty(PizzaName)) { PizzaName = "Custom"; }
            if(String.IsNullOrEmpty(ImageTitle)) { ImageTitle = "Create"; }
        }
    }
}
