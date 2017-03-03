using System;

namespace ChessCS
{
	class CommandHandler
	{
		public static ConsoleColor ActiveColor = ConsoleColor.White;

		/// <summary>
		/// Checks the current active player
		/// </summary>
		/// <returns><c>true</c>, if player was active, <c>false</c> otherwise.</returns>
		/// <param name="Color">Color.</param>
		public static bool isActive(ConsoleColor Color)
		{
			return 
				(Color == ConsoleColor.White && ActiveColor == ConsoleColor.White) 
				| (Color == ConsoleColor.Black && ActiveColor == ConsoleColor.Black);
		}

		/// <summary>
		/// Reads input from the user to get the next move on the board
		/// </summary>
		/// <returns>The move.</returns>
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