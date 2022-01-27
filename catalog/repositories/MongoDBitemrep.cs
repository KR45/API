using System;
using System.Collections.Generic;
using catalog.entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace catalog.repositories
{
    public class MongoDBitemrep : itemrepos
    {
        private const string  databaseName = "Catalog";

        private const string collectionName = "items";
        private readonly IMongoCollection<Item> itemsCollection; // storing collection in Mongo DB


        public MongoDBitemrep(IMongoClient mongoClient) // constructor and injecting database of MOngo DB
        {
            IMongoDatabase database = mongoClient.GetDatabase(databaseName); // reference to our database
            itemsCollection = database.GetCollection<Item>(collectionName); //create new collection irrespective of old database


        }
        public void CreateItem(Item item)
        {
           itemsCollection.InsertOne(item);
        }

        public void DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public Item GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetItems()
        {
            return itemsCollection.Find(new BsonDocument()).ToList();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}