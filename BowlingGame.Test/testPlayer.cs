using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class testPlayer
    {
        [TestMethod]
        public void playerTest()
        {
            Player player =  new Player("Nicolas");

            StringAssert.Contains(player.getName(), "Nicolas");
        }
    }
}