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
        public ObjectId Id { get; set; }
        [BsonElement("NBD_No")]
        public string NBD_No { get; set; }
        [BsonElement("Shrt_Desc")]
        public string Shrt_Desc { get; set; }
        [BsonElement("GmWt1")]
        public string GmWt1 { get; set; }
        [BsonElement("GmWt_Desc1")]
        public string GmWt_Desc1 { get; set; }
        [BsonElement("GmWt2")]
        public string GmWt2 { get; set;  }
        [BsonElement("GmWt_Desc2")]
        public string GmWt_Desc2 { get; set; }
        [BsonElement("Calories")]
        public double Calories { get; set; }
        [BsonElement("Protein")]
        public double Protein { get; set; }
        [BsonElement("Fat")]
        public double Fat { get; set; }
        [BsonElement("Carbohydate")]
        public double Carbohydate { get; set; }
        [BsonElement("Fiber")]
        public double Fiber { get; set; }
        [BsonElement("Sugar")]
        public double Sugar { get; set; }
        [BsonElement("Calcium")]
        public double Calcium { get; set; }
        [BsonElement("Iron")]
        public double Iron { get; set; }
        [BsonElement("Potassium")]
        public double Potassium { get; set; }
        [BsonElement("Sodium")]
        public double Sodium { get; set; }
        [BsonElement("Vitamin_C")]
        public double Vitamin_C { get; set; }
        [BsonElement("Vit_A_IU")]
        public double Vit_A_IU { get; set; }
        [BsonElement("Vit_D_IU")]
        public double Vit_D_IU { get; set; }
        [BsonElement("Cholestrol")]
        public double Cholestrol { get; set; }
        public Ingredient(){}

        public void print()
        {
            Console.WriteLine("Ingredient No.: " + NBD_No);
            Console.WriteLine("Description: " + Shrt_Desc);
        }
    }
}
