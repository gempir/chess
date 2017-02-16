using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Knight : Figure
	{
		public Knight(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♘' : 'N';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			throw new NotImplementedException();
		}
	}
}
