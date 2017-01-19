using System;
namespace ChessCS
{
	class Queen : Figure
	{
		public Queen(ConsoleColor color)
		{
			Symbol = '♕';
			Color = color;
		}
	}
}
