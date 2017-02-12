using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Rook : Figure
	{
		public Rook(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♖' : 'R';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			throw new NotImplementedException();
		}
	}
}
