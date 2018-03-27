using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using IEatHealthy.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.AspNetCore.Http;


namespace IEatHealthy.Controllers
{
    public class RecipeController : Controller
    {
        [HttpPost]
        public IActionResult Index(Recipe recipe, IFormFile image)
        {
            //Reads the uploaded image and stores it as a sequence of bytes. 
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
            recipe.FoodImage = new BsonBinaryData(buffer); 
           
            //Gets the db and the recipe collection.
            MongoClient _client = MongoClientFactory.GetInstance();
            var db = _client.GetDatabase("food-data");
            var collection = db.GetCollection<Recipe>("recipes");

            //Inserts the recipe into the collection.
            collection.InsertOne(recipe); 


            //Clears the model so that all previous input fields are cleared. 
            ModelState.Clear();
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
