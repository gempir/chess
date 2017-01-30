using System;
namespace ChessCS
{
	abstract class Figure
	{
		// The actual Symbol is always the white version in unicode
		// The color is defined by the color property
		protected Char Symbol;

		public ConsoleColor Color { get; protected set; }

		public override string ToString()
		{
			return Symbol.ToString();
		}

		// On windows the default console does not support Unicode
		protected bool isUnixSystem()
		{
			return Environment.OSVersion.ToString().Contains("Unix");
		}

		abstract public bool isValidMove(Move move);
	}
}
