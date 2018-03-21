using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;


namespace IEatHealthy.Controllers
{
    public class RecipeController : Controller
    {
        [HttpPost]
        public IActionResult Index(Recipe recipe)
        {
            //TODO input validation if any and submit recipe to database 
            ModelState.Clear();
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
