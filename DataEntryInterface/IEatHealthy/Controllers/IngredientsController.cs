﻿using System;
using System.Collections.Generic;
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
            //TODO input validation if any and submit 'ingredient' to database
            ModelState.Clear();
            return View("~/Views/Home/Ingredients.cshtml");
        }
    }
}
