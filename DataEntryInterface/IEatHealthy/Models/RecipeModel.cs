using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace IEatHealthy.Models
{
    public enum DifficultyType
    {
        easy = 1,
        intermediate = 2,
        hard = 3
    };

    public class IngredientItem {
        public string desc { get; set; }
        [BsonRepresentation(BsonType.ObjectId)]
        public string ingredientId { get; set; }
        public string unitOfMeasure { get; set; }
        public float amount { get; set; }
    }

    public enum foodType
    {
        italian = 1,
        mexican = 2,
        chinese = 3,
        brazilian = 4,
        american = 5,
        japanese = 6,
        indian = 7,
        thai = 8,
        greek = 9,
        spanish = 10,
        french = 11,
        german = 12,
        portugese = 13,
        other = 30
    };

    public class Recipe
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("typeOfFood")]
        public foodType typeOfFood { get; set; }
        [BsonElement("difficulty")]
        public DifficultyType difficulty { get; set; }
        [BsonElement("servings")]
        public float servings { get; set; }
        [BsonElement("prepTime")]
        public float prepTime { get; set; }
        [BsonElement("cookTime")]
        public float cookTime { get; set; }
        [BsonElement("readyInTime")]
        public float readyInTime { get; set; }
        [BsonElement("ingredients")]
        public List<IngredientItem> ingredients { get; set; }
        [BsonElement("steps")]
        public List<string> steps { get; set; }
        [BsonElement("toolsNeeded")]
        public List<string> toolsNeeded { get; set; }
        [BsonElement("description")]
        public string description { get; set; }
        [BsonElement("author")]
        public string author { get; set; }
        [BsonElement("calories")]
        public double calories { get; set; }
        [BsonElement("protein")]
        public double protein { get; set; }
        [BsonElement("fat")]
        public double fat { get; set; }
        [BsonElement("carbohydrate")]
        public double carbohydrate { get; set; }
        [BsonElement("fiber")]
        public double fiber { get; set; }
        [BsonElement("sugar")]
        public double sugar { get; set; }
        [BsonElement("calcium")]
        public double calcium { get; set; }
        [BsonElement("iron ")]
        public double iron { get; set; }
        [BsonElement("potassium")]
        public double potassium { get; set; }
        [BsonElement("sodium")]
        public double sodium { get; set; }
        [BsonElement("vitaminC ")]
        public double vitaminC { get; set; }
        [BsonElement("vitAiu")]
        public double vitAiu { get; set; }
        [BsonElement("vitDiu")]
        public double vitDiu { get; set; }
        [BsonElement("cholestrol")]
        public double cholestrol { get; set; }
        [BsonElement("foodImage")]
        public BsonBinaryData foodImage { get; set; }

        public Recipe() {}
    }
}
