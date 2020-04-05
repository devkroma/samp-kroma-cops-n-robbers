using KromaCnR.Data.Services.Users;

namespace KromaCnR
{
    class Injection
    {
        public static readonly IUserService UserService = new UserService();
    }
}
