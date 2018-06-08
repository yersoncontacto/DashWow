using WowDotNetAPI;
using WowDotNetAPI.Models;

namespace DashWowCore
{
    public class Class1
    {

        private static WowExplorer explorer;
        private static Guild guild;
        private static string APIKey = "p4bnuju7grf3qfdcgbpwec8ebf5hq29g";


        public Guild GetMyGuild()
        {
            var myGuild = explorer.GetGuild(Region.US, "Stormrage", "Serenity Later");
            return myGuild;
        }
    }
}
