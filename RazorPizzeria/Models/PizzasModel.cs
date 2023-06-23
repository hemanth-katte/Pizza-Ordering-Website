namespace RazorPizzeria.Models
{
	public class PizzasModel
	{
        public string ImageTitle { get; set; }

		public string PizzaName { get; set; }

        public float BasePrice { get; set; }

        public bool Cheese { get; set; }

        public bool TomatoSauce { get; set; }

        public bool Onion { get; set; }

        public bool Paneer { get; set; }

        public bool Capcicum { get; set; }

        public bool Corn { get; set; }

        public bool Olives { get; set; }

        public bool Jalapenos { get; set; }

        public float FinalPrice { get; set; }
    }

}
