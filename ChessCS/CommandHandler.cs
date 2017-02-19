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
				Console.WriteLine("It's white's move.");
			}
			else {
				Console.WriteLine("It's black's move.");
			}
			Console.Write("From field: ");
			char fromChar = Console.ReadKey().KeyChar;
			char fromNum = Console.ReadKey().KeyChar;

			Console.Write("\r\n");

			Console.Write("To field: ");
			char toChar = Console.ReadKey().KeyChar;
			char toNum = Console.ReadKey().KeyChar;

			string from = fromChar.ToString().ToUpper() + fromNum.ToString();
			string to = toChar.ToString().ToUpper() + toNum.ToString();

			return new Move(from, to);
		}
	}
}