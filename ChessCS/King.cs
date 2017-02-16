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
			int fromChar = (int)move.From[0];
			int toChar = (int)move.To[0];

			int fromNum = (int)(move.From[1] - '0');
			int toNum = (int)(move.To[1] - '0');

			if (Math.Abs(fromChar - toChar) > 1)
			{
				return false;
			}
			if (Math.Abs(fromNum - toNum) > 1)
			{
				return false;
			}
			return true;
		}
	}
}
