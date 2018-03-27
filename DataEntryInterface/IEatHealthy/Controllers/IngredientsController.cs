using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;


namespace IEatHealthy.Controllers
{
    public class IngredientsController : Controller
    {
        [HttpPost]
        public IActionResult Ingredients(Ingredient ingredient)
        {
            //Gets db and the ingredient collection.
            MongoClient _client = MongoClientFactory.GetInstance();
            var db = _client.GetDatabase("food-data");
            var collection = db.GetCollection<Ingredient>("ingredients");

            //Inserts the ingredient into the collection.
            collection.InsertOne(ingredient);

            //Clears the model so that all previous input fields are cleared. 
            ModelState.Clear();
            return View("~/Views/Home/Ingredients.cshtml");
        }
    }
}
