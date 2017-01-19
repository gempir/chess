using System;
namespace ChessCS
{
	class Pawn : Figure
	{
		public Pawn(ConsoleColor color)
		{
			Symbol = '♙';
			Color = color;
		}
	}
}
