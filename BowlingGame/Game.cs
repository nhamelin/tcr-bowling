using System;
using BowlingGame;

namespace BowlingGame
{
	public class Game
	{
		private List<Pins> pins;

        public Game()
		{

		}

		public List<Pins>  InitPins()
		{
			for (int i = 0; i <= 9; i++)
			{
				Pins pin = new Pins();
				pins.Add(pin);
			}

			return pins;
		}


	}
}

