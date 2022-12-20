using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Model
{
    public class Movie
    {
        [BsonId]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set;}
        public float MovieDuration { get; set; }
        public string MovieDirectorID { get; set; }
    }
}
