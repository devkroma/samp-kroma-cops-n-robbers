using KromaCnR.Data.Models;
using System.Threading.Tasks;

namespace KromaCnR.Data.Services.Users
{
    interface IUserService
    {
        Task<User> GetUserById(string id);
        Task<User> GetUserByUsername(string username);
        Task<string> CreateUser(User user);
        Task<bool> UpdateUser(User user);
    }
}
