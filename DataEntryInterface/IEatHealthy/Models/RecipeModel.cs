using System;
using System.Collections.ObjectModel;
using MongoDB.Bson;

namespace IEatHealthy.Models
{
    public enum DifficultyType
    {
        Easy = 1,
        Intermediate = 2,
        Hard = 3
    };

    public class Recipe
    {
        //public ObjectId ObjectId { get; private set; }
        public string Name { get; set; }
        public DifficultyType Difficulty { get; set; }
        public float Servings { get; set; }
        public float PrepTime { get; set; }
        public float CookTime { get; set; }
        public float ReadyInTime { get; set; }
        //TODO switch this array out with array of Ingredient model class
        //TODO don't use array as property, it's dangerous out there
        public string[] Ingredients { get; set; }
        public string[] Steps { get; set; }
        public string[] ToolsNeeded { get; set; }
        public string Description { get; set; }
        //TODO need to handle image data
        public string Author { get; set; }
        public int Calories { get; set; }
        public float Fat { get; set; }
        public float Protein { get; set; }
        public float Carbohydrates { get; set; }
    }
}
