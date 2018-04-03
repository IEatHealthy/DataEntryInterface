using System;
using System.Diagnostics;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace IEatHealthy.Models
{
    public class Ingredient
    {
        //Note, all properties are guaranteed to be
        //initialized before submitting to the database
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("nbdNo")]
        public string nbdNo{ get; set; }
        [BsonElement("shrtDesc")]
        public string shrtDesc { get; set; }
        [BsonElement("gmWt1")]
        public string gmWt1 { get; set; }
        [BsonElement("gmWtDesc1")]
        public string gmWtDesc1 { get; set; }
        [BsonElement("gmWt2")]
        public string gmWt2 { get; set;  }
        [BsonElement("gmWtDesc2")]
        public string gmWtDesc2 { get; set; }
        [BsonElement("calories")]
        public double calories { get; set; }
        [BsonElement("protein")]
        public double protein { get; set; }
        [BsonElement("fat")]
        public double fat { get; set; }
        [BsonElement("carbohydate")]
        public double carbohydate { get; set; }
        [BsonElement("fiber")]
        public double fiber { get; set; }
        [BsonElement("sugar")]
        public double sugar { get; set; }
        [BsonElement("calcium")]
        public double calcium { get; set; }
        [BsonElement("iron")]
        public double iron { get; set; }
        [BsonElement("potassium")]
        public double potassium { get; set; }
        [BsonElement("sodium")]
        public double sodium { get; set; }
        [BsonElement("vitaminC")]
        public double vitaminC { get; set; }
        [BsonElement("vitAiu")]
        public double vitAiu { get; set; }
        [BsonElement("vitDiu")]
        public double vitDiu { get; set; }
        [BsonElement("cholestrol")]
        public double cholestrol { get; set; }
        public Ingredient(){}

        public void print()
        {
            Console.WriteLine("Ingredient No.: " + nbdNo);
            Console.WriteLine("Description: " + shrtDesc);
        }
    }
}
