using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class testPlayer
    {
        [TestMethod]
        public void playerTest()
        {
            Player player new Player();

            StringAssert.DoesNotMatch(expectedNbPins, nbPins, 10, "Nbpins is correctly");
        }
    }
}