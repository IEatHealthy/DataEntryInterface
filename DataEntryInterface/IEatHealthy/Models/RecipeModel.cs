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
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Difficulty")]
        public DifficultyType Difficulty { get; set; }
        [BsonElement("Servings")]
        public float Servings { get; set; }
        [BsonElement("PrepTime")]
        public float PrepTime { get; set; }
        [BsonElement("CookTime")]
        public float CookTime { get; set; }
        [BsonElement("ReadyInTime")]
        public float ReadyInTime { get; set; }
        [BsonElement("Ingredients")]
        public List<IngredientItem> Ingredients { get; set; }
        [BsonElement("Steps")]
        public List<string> Steps { get; set; }
        [BsonElement("ToolsNeeded")]
        public List<string> ToolsNeeded { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        //TODO need to handle image data
        [BsonElement("Author")]
        public string Author { get; set; }
        [BsonElement("Calories")]
        public double Calories { get; set; }
        [BsonElement("Protein")]
        public double Protein { get; set; }
        [BsonElement("Fat")]
        public double Fat { get; set; }
        [BsonElement("Carbohydrates")]
        public double Carbohydrates { get; set; }
        [BsonElement("Fiber")]
        public double Fiber { get; set; }
        [BsonElement("Sugar")]
        public double Sugar { get; set; }
        [BsonElement("Calcium")]
        public double Calcium { get; set; }
        [BsonElement("Iron ")]
        public double Iron { get; set; }
        [BsonElement("Potassium")]
        public double Potassium { get; set; }
        [BsonElement("Sodium")]
        public double Sodium { get; set; }
        [BsonElement("Vitamin_C ")]
        public double Vitamin_C { get; set; }
        [BsonElement("Vit_A_IU")]
        public double Vit_A_IU { get; set; }
        [BsonElement("Vit_D_IU")]
        public double Vit_D_IU { get; set; }
        [BsonElement("Cholesterol")]
        public double Cholesterol { get; set; }
        [BsonElement("FoodImage")]
        public BsonBinaryData FoodImage { get; set; }

        public Recipe() {}
    }
}
