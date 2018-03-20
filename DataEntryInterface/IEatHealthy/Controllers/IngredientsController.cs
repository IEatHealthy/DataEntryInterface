using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;


namespace IEatHealthy.Controllers
{
    public class IngredientsController : Controller
    {
        [HttpPost]
        public IActionResult Ingredients(Ingredient ingredient)
        {
            //In case you want to see the input
            Debug.WriteLine(ingredient.printIngredient());
            ModelState.Clear();
            return View("~/Views/Home/Ingredients.cshtml");
        }
    }
}
