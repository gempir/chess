using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Pawn : Figure
	{
		public Pawn(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♙' : 'P';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			throw new NotImplementedException();
		}
	}
}
