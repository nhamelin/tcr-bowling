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
			this.pins = new List<Pins>();

			for (int i = 0; i <= 9; i++)
			{
				Pins pin = new Pins(i);
				pins.Add(pin);
			}

			return pins;
		}


	}
}

