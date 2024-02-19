using System;
using MongoDB.Driver;

namespace guest_manager_cli_system
{
    class DatabaseDebugger
    {
        public DatabaseDebugger()
        {

            MongoClient client = new MongoClient("mongodb://localhost:27017/");

            var databaseList = client.ListDatabases().ToList();

            Console.WriteLine("The list of databases on this server is: ");

            foreach (var database in databaseList)
            {
                Console.WriteLine(database);
            }

        }
    }
}