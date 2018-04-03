using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;





namespace IEatHealthy.Controllers
{
    public class RecipeController : Controller
    {
        static MongoClient _client = MongoClientFactory.GetInstance();
        IMongoDatabase db = _client.GetDatabase("food-data");

        [HttpPost]
        public IActionResult Index(Recipe recipe, IFormFile image)
        {
            //Gets the recipe collection.
            var collection = db.GetCollection<Recipe>("recipes");

            //Reads the uploaded image and stores it as a sequence of bytes.
            //Note: will give error if no image is provided.
            Stream imageData = image.OpenReadStream();
            imageData.Position = 0;

            //Buffer for the image data.
            byte[] buffer = new byte[imageData.Length];

            //Creates the byte array for the image data. 
            for (int totalBytesCopied = 0; totalBytesCopied < imageData.Length;)
            {
                totalBytesCopied += imageData.Read(buffer, totalBytesCopied, Convert.ToInt32(imageData.Length) - totalBytesCopied);
            }

            //Image is stored as BsonBinaryData in database. 
            recipe.foodImage = new BsonBinaryData(buffer);

            //Removes empty tool when no tools are entered. 
            if (recipe.toolsNeeded[0] == null)
            {
                recipe.toolsNeeded.RemoveAt(0);
            }
            //Inserts the recipe into the collection.
            collection.InsertOne(recipe);

            //Clears the model so that all previous input fields are cleared. 
            ModelState.Clear();
            ViewData["ingredientsFound"] = new List<Ingredient>();
            return View("~/Views/Home/Index.cshtml");
        }

        [HttpPost]
        public IActionResult SearchIngredientId(Recipe recipe, String textToFind)
        {
            //Gets the ingredients collection.
            var collection = db.GetCollection<Ingredient>("ingredients");

            var filter = Builders<Ingredient>.Filter.Regex("shrtDesc", new BsonRegularExpression(textToFind, "i"));
            var listOfIngredients = collection.Find(filter).ToList();

            //ViewData stores the ingredients returned to pass data from controller to view. 
            ViewData["ingredientsFound"] = listOfIngredients;

            return View("~/Views/Home/Index.cshtml");
        }
    }
}