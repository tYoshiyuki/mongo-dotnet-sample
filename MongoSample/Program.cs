using MongoDB.Driver;
using MongoSample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = ConfigurationManager.AppSettings["MongoDBConnection"];
            var client = new MongoClient(connectionString);

            var db = client.GetDatabase(ConfigurationManager.AppSettings["Db"]);
            var collection = db.GetCollection<SampleCollection>("sampleCollection");

            var sc = new SampleCollection
            {
                Data = "でーた",
                Val = "ばりゅー"
            };

            collection.InsertOne(sc);

            var scs = collection.Find(_ => true).ToList();
            foreach(var c in scs)
            {
                Console.WriteLine($"{c.Id}/{c.Data}");
            }
        }
    }
}
