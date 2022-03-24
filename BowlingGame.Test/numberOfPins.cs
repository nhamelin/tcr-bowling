using Microsoft.VisualStudio.TestTools.UnitTesting;

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

            Pins pin = new Pins(1);

            Game game = new Game();

            foreach (Pins pin in game.pins[])
            {
                nbPins++;
            }
            Assert.AreEqual(expectedNbPins, nbPins, 10, "Nbpins is correctly");

            //if (nbPins > expectedNbPins)
            //{
            //    Console.WriteLine("Trop de quilles");
            //} else if(nbPins < expectedNbPins)
            //{
            //    Console.Writeline("Pas assez de quilles");
            //} else
            //{
            //    Console.Writeline("C'est bon");
            //}
            //int nbPins = 0;
            //int expectedNbPins = 10;

            //Game game = new Game();

            //foreach(pins in game.pins[])
            //{
            //    nbPins++;
            //}
            //Assert.AreEqual(expectedNbPins, nbPins,10, "Nbpins not correctly");

            //if (nbPins > expectedNbPins)
            //{
            //    Console.Writeline("Trop de quilles");
            //} else if(nbPins < expectedNbPins)
            //{
            //    Console.Writeline("Pas assez de quilles");
            //} else
            //{
            //    Console.Writeline("C'est bon");
            //}
        }
    }
}