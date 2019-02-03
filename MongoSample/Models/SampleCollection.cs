using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoSample.Models
{
    public class SampleCollection
    {
        public ObjectId Id { get; set; }
        public string Data { get; set; }
        public string Val { get; set; }
    }
}
