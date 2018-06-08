using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WowDotNetAPI;

namespace DashWowCore.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        private static WowExplorer explorer;
        private static string APIKey = "p4bnuju7grf3qfdcgbpwec8ebf5hq29g";

        [TestMethod()]
        public void GetMyGuildTest()
        {
            var myGuild = explorer.GetGuild(Region.US, "Stormrage", "Serenity Later");
            Assert.IsNotNull(myGuild);
            Assert.Fail();
        }
    }
}