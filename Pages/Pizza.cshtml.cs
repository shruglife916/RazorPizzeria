using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModels> fakePizzaDB = new List<PizzasModels>()
        {
            new PizzasModels(){
                ImageTitle="Margerita",
                PizzaName="Margherita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4
            },
            new PizzasModels() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "MeatFeast", PizzaName =  "MeatFeast", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
            new PizzasModels() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice=4},
        };
        public void OnGet()
        {
        }
    }
}
