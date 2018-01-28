using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using Traveler.Models;

namespace Traveler.DataAccess
{
    public interface IGuideRepository
    {
        Task<City> Get(ObjectId id);
        Task<List<City>> Get(string query = "");
    }

    public class GuideRepository : IGuideRepository
    {
        private readonly string _collectionName = "";
        private readonly IConfiguration _config;

        public string ConnectionString => _config.GetValue<string>("Database:connectionString");
        public string DbName => _config.GetValue<string>("Database:DbName");

        public GuideRepository(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<City> Get(ObjectId id)
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DbName);
            var collection = database.GetCollection<City>(_collectionName);
            using (var cursor = await collection.FindAsync(x => x.Id == id))
            {
                return await cursor.FirstOrDefaultAsync();
            }
            //var fs = new GridFSBucket(database);

            //var id = UploadFile(fs);

            //DownloadFile(fs, id);
        }

        public async Task<List<City>> Get(string query = "")
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DbName);
            var collection = database.GetCollection<City>(_collectionName);

            using (var cursor = await collection.FindAsync(x => x.Name.Contains(query)))
            {
                return await cursor.ToListAsync();
            }
        }

        private static ObjectId UploadFile(GridFSBucket fs)
        {
            using (var s = File.OpenRead(@"C:\Projects\traveler\server\Traveler\UnitTests\data\1.txt"))
            {
                var t = Task.Run<ObjectId>(() => fs.UploadFromStreamAsync("1.txt", s));

                return t.Result;
            }
        }

        private static void DownloadFile(GridFSBucket fs, ObjectId id)
        {
            //This works
            var t = fs.DownloadAsBytesByNameAsync("test.txt");
            Task.WaitAll(t);
            var bytes = t.Result;


            //This blows chunks (I think it's a driver bug, I'm using 2.1 RC-0)
            var x = fs.DownloadAsBytesAsync(id);
            Task.WaitAll(x);
        }
    }
}
