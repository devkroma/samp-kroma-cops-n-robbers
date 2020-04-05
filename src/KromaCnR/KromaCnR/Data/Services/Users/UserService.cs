using KromaCnR.Data.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System.Threading.Tasks;

namespace KromaCnR.Data.Services.Users
{
    class UserService : IUserService
    {
        public async Task<string> CreateUser(User user)
        {
            await MongoContext.Instance.Users
                .InsertOneAsync(user);

            return user.Id.ToString();
        }

        public async Task<User> GetUserById(string id)
        {
            var objectId = ObjectId.Parse(id);
            return await MongoContext.Instance.Users
                .AsQueryable()
                .Where(user => user.Id == objectId)
                .FirstOrDefaultAsync();
        }

        public async Task<User> GetUserByUsername(string username)
        {
            return await MongoContext.Instance.Users
                .AsQueryable()
                // TODO Filter this properly
                .Where(user => user.Username.ToLower() == username.ToLower())
                .FirstOrDefaultAsync();
        }

        public Task<bool> UpdateUser(User user)
        {
            throw new System.NotImplementedException();
        }
    }
}
