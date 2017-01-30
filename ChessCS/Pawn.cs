using System;
namespace ChessCS
{
	class Pawn : Figure
	{
		public Pawn(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♙' : 'P';
			Color = color;
		}
	}
}
