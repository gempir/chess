using System;

namespace ChessCS
{
	class CommandHandler
	{
		public int ActivePlayer = 0;

		public CommandHandler()
		{
			
		}

		public Move getMove()
		{
			if (ActivePlayer == 0)
			{
				Console.WriteLine("It's White's move.");
			}
			else {
				Console.WriteLine("It's Black's move.");
			}
			Console.Write("Which figure do you want to move (Enter Field): ");
			string from = Console.ReadLine();
			Console.Write("Which field do you want to move to: ");
			string to = Console.ReadLine();

			return new Move(from, to);
		}
	}
}