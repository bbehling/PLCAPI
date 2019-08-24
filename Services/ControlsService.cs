using ControlsApi.Models;
using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json.Linq;

namespace ControlsApi.service {
    public class ControlsService { 
        private readonly IMongoCollection<BsonDocument> _controls;

        public ControlsService(IControlsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _controls = database.GetCollection<BsonDocument>(settings.ControlsCollectionName);
        }

        public JArray Get() {

            var myArray = new JArray();
            //var docs = _books.Find(_ => true).Project(Builders<BsonDocument>.Projection.Exclude("_id")).ToList();

            var json = _controls.Find(_ => true).ToList().ToJson(new JsonWriterSettings { OutputMode = JsonOutputMode.Strict });

            return JArray.Parse(json);
        }
    }
}