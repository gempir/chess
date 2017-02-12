using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Queen : Figure
	{
		public Queen(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♕' : 'Q';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			throw new NotImplementedException();
		}
	}
}
