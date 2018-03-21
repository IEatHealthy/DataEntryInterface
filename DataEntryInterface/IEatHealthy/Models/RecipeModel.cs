using System;
using System.Diagnostics;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IEatHealthy.Models
{
    public enum DifficultyType
    {
        Easy = 1,
        Intermediate = 2,
        Hard = 3
    };

    public class IngredientItem {
        [BsonRepresentation(BsonType.ObjectId)]
        public string IngredientId { get; set; }
        public string UnitOfMeasure { get; set; }
        public float Amount { get; set; }
    }

    public class Recipe
    {
        public string Name { get; set; }
        public DifficultyType Difficulty { get; set; }
        public float Servings { get; set; }
        public float PrepTime { get; set; }
        public float CookTime { get; set; }
        public float ReadyInTime { get; set; }
        public List<IngredientItem> Ingredients { get; set; }
        public List<string> Steps { get; set; }
        public List<string> ToolsNeeded { get; set; }
        public string Description { get; set; }
        //TODO need to handle image data
        public string Author { get; set; }
        public int Calories { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float Carbohydrates { get; set; }
    }
}
