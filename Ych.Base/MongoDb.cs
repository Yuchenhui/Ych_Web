using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using Ych.Model;

namespace Ych.Base
{
    public class MongoDb
    {
        private static readonly MongoDb instance = new MongoDb();

        private static readonly string MongoDbServer = "mongodb://" +
                                                       ConfigurationManager.AppSettings["mongoDb_Server_path"];

        private static readonly string MongoDbServerUserName = ConfigurationManager.AppSettings["mongoDb_Server_name"];

        private static readonly string MongoDbServerPassword =
            ConfigurationManager.AppSettings["mongoDb_Server_password"];

        private static readonly string MongoDbServerDatabase = ConfigurationManager.AppSettings["mongoDb_Database"];

        private MongoDatabase database;

        private MongoServer server;

        private MongoDb()
        {
            
        }

        public static MongoDb Instance
        {
            get { return instance; }
        }

        public MongoCollection GetCollection<T>()
        {
            MongoClient mongoClient = new MongoClient(MongoDbServer);
            server = mongoClient.GetServer();
            database = server.GetDatabase(MongoDbServerDatabase);
            var model = typeof(T);
            return database.GetCollection<T>(model.Name);
        }

        
    }
}
