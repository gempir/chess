using System;
namespace ChessCS
{
	class King : Figure
	{
		public King(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♔' : 'K';
			Color = color;
		}
	}
}
