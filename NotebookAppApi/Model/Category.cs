using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotebookAppApi.Model
{
    /*
            "_id" : ObjectId("53963e908fba26447f61c48e"),
            "meta_description" : "The best way to see Iceland, away from the crowds, is a private super jeep tour, on modified 4x4 trucks.",
            "meta_tags" : "Iceland tours, best tour in Iceland, best tour company in Iceland, private tours, 4x4 tours, see Iceland,",
            "name" : "4X4 Superjeep day tours",
            "alt_title" : "4x4-superjeep-day-tours"
     */

    public class Category
    {
        [BsonId]
        public ObjectId _id { get; set; }
        [BsonElement("meta_description")]
        public string MetaDescription { get; set; }
        [BsonElement("meta_tags")]
        public string MetaTags { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("alt_title")]
        public string AltTitle { get; set; }
    }
}
