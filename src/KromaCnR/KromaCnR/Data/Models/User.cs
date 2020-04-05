using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KromaCnR.Data.Models
{
    class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
