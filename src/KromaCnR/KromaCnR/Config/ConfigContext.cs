using Microsoft.Extensions.Configuration;

namespace KromaCnR.Config
{
    class ConfigContext
    {
        public static readonly IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();
    }
}
