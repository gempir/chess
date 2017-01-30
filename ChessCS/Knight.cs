using System;
namespace ChessCS
{
	class Knight : Figure
	{
		public Knight(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♘' : 'N';
			Color = color;
		}
	}
}
