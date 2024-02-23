using System;
using MongoDB.Driver;
using MongoDB.Bson;

namespace guest_manager_cli_system
{
    class Program
    {
        static void Main(string[] args)
        {

            // DatabaseDebugger debugger = new DatabaseDebugger();
            GuestController Controller = new GuestController();

            MongoClient Client = new MongoClient("mongodb://localhost:27017/");
            var Database = Client.GetDatabase("cs-api");
            
            var Collection = Database.GetCollection<BsonDocument>("users");
            
            BsonDocument modifier = Controller.CreateDocument("Jeremy","Gilbert",17);
            Controller.Update(Collection,);
            Controller.Read(Collection);

        }

    }
}