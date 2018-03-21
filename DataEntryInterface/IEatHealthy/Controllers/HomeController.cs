﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;

namespace IEatHealthy.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Add a Recipe";
            return View();
        }

        [HttpGet]
        public IActionResult Ingredients()
        {
            ViewData["Title"] = "Add Ingredients";
            return View();
        }

        public IActionResult EditRecipes()
        {

            ViewData["Title"] = "Edit Recipes";
            return View();
        }

        public IActionResult EditIngredients()
        {

            ViewData["Title"] = "Edit Ingredinents";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
