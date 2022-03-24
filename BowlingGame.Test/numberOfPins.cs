using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGame.Test
{
    [TestClass]
    public class numberOfPins
    {
        [TestMethod]
        public void numberOfPinsTest()
        {
            int nbPins = 0;
            int expectedNbPins = 10;

            Game game = new Game();

            foreach(pins in game.Pins[])
            {
                nbPins++;
            }

            if(nbPins > expectedNbPins)
            {
                Console.Write("Trop de quilles");
            } else if(nbPins < expectedNbPins)
            {
                Console.Write("Pas assez de quilles");
            } else
            {
                Console.Write("C'est bon");
            }
        }
    }
}