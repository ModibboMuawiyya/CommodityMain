using Microsoft.Extensions.Configuration;

namespace CommodityMainAPI.Helpers
{
    public static class Helper
    {
        private static string serviceUrl;

        public static string ServiceUrl
        {
            get
            {
                if (string.IsNullOrEmpty(serviceUrl))
                {
                    serviceUrl = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["serviceUrl"];

                }
                return serviceUrl;
            }
        }
    }
}
