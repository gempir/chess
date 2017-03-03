using System;
using System.Collections.Generic;

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

		/// <summary>
		/// For validation purposes this function is needed a lot
		/// </summary>
		/// <returns>The field for an int char and number.</returns>
		/// <param name="character">Character.</param>
		/// <param name="num">Number.</param>
		protected string getFieldForaIntCharAndNum(int character, int num)
		{
			return (Char.ConvertFromUtf32(character) + num.ToString()).ToString();
		}

		/// <summary>
		/// Validate a move, the implementation of this method is up to the child classes
		/// </summary>
		/// <returns><c>true</c>, if valid move was issued, <c>false</c> otherwise.</returns>
		/// <param name="move">Move.</param>
		/// <param name="boardPositions">Board positions.</param>
		abstract public bool isValidMove(Move move, Dictionary<string, Figure> boardPositions);
	}
}
