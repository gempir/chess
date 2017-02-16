using System;
using System.Collections.Generic;

namespace ChessCS
{
	class King : Figure
	{
		public King(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♔' : 'K';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			throw new NotImplementedException();
		}
	}
}
