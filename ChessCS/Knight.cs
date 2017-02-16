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
			int fromChar = (int)move.From[0];
			int fromNum = (int)(move.From[1] - '0');


			List<string> fieldList = new List<string>();

			fieldList.Add(getFieldForaIntCharAndNum(fromChar - 2, fromNum - 1));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar - 2, fromNum + 1));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar - 1, fromNum - 2));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar - 1, fromNum + 2));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar + 1, fromNum - 2));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar + 1, fromNum + 2));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar + 2, fromNum - 1));
			fieldList.Add(getFieldForaIntCharAndNum(fromChar + 2, fromNum + 1));


			if (fieldList.Contains(move.To)) {
				return true;
			}

			return false;

		}
	}
}
