using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace guest_manager_cli_system
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseDebugger debugger = new DatabaseDebugger();
            GuestModel Model = new GuestModel();

            MongoClient Client = new MongoClient("mongodb://localhost:27017/");
            var Database = Client.GetDatabase("cs-api");
            
            var Collection = Database.GetCollection<BsonDocument>("users");
            
            Model.Create(Collection,"Elena","Gilbert",17);
            Model.Read(Collection);

        }

    }
}