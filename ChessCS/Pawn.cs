using System;
namespace ChessCS
{
	class Pawn : Figure
	{
		public Pawn(string color)
		{
			Symbol = '♙';
			Color = color;
		}
	}
}
