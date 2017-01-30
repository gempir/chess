using System;
namespace ChessCS
{
	class Queen : Figure
	{
		public Queen(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♕' : 'Q';
			Color = color;
		}
	}
}
