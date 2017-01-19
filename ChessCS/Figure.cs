using System;
namespace ChessCS
{
	abstract class Figure
	{
		// The actual Symbol is always the white version in unicode
		// The color is defined by the color property
		protected Char Symbol;

		public string Color { get; protected set; }

		public override string ToString()
		{
			return Symbol.ToString();
		}
	}
}
