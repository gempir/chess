using System;

namespace ChessCS
{
	class CommandHandler
	{
		public static int ActivePlayer = 0;

		public CommandHandler()
		{
			
		}

		public static bool isActive(ConsoleColor Color)
		{
			return 
				(Color == ConsoleColor.White && ActivePlayer == 0) 
				| (Color == ConsoleColor.Black && ActivePlayer == 1);
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

			return new Move(from.ToUpper(), to.ToUpper());
		}
	}
}