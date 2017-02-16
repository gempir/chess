using System;

namespace ChessCS
{
	class CommandHandler
	{
		public static ConsoleColor ActiveColor = ConsoleColor.White;

		public static bool isActive(ConsoleColor Color)
		{
			return 
				(Color == ConsoleColor.White && ActiveColor == ConsoleColor.White) 
				| (Color == ConsoleColor.Black && ActiveColor == ConsoleColor.Black);
		}

		public Move getMove()
		{
			if (ActiveColor == ConsoleColor.White)
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