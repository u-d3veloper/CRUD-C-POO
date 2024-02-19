using System;
using System.Collections.ObjectModel;
using MongoDB.Bson;
using MongoDB.Driver;

namespace guest_manager_cli_system
{
    public class GuestModel
    {
        public GuestModel(){

        }

        public void Read(IMongoCollection<BsonDocument> collection)
        {
            var documents = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();
            foreach (var document in documents)
            {
                Console.WriteLine(document);
            }
        }

        public void Create(IMongoCollection<BsonDocument> collection, string firstName,string lastName, int age)
        {
            collection.InsertOne(CreateDocument(firstName,lastName,age));
        }

        private BsonDocument CreateDocument(string firstName,string lastName, int age)
        {
            return new BsonDocument{
                {"guest_id", new Random().Next(100000)},
                {"last-name",lastName},
                {"first-name",firstName},
                {"age",age}
            };

        }
    }
}