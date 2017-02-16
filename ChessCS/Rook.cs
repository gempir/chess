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
			int fromChar = (int)move.From[0];
			int toChar = (int)move.To[0];

			int fromNum = (int)(move.From[1] - '0');
			int toNum = (int)(move.To[1] - '0');

			if (fromNum != toNum && fromChar != toChar)
			{
				return false;
			}

			List<string> fieldsToCheck = new List<string>();

			if (fromNum != toNum)
			{
				int fieldsBetween = Math.Abs(toNum - fromNum) - 1;

				for (int i = 1; i <= fieldsBetween; i++)
				{
					if (fromNum > toNum)
					{
						fieldsToCheck.Add(getFieldForaIntCharAndNum(fromChar, fromNum - i));
					}
					if (fromNum < toNum)
					{
						fieldsToCheck.Add(getFieldForaIntCharAndNum(fromChar, fromNum + i));
					}
				}

			}
			if (fromChar != toChar)
			{
				int fieldsBetween = Math.Abs(fromChar - toChar) - 1;

				for (int i = 1; i <= fieldsBetween; i++)
				{
					if (fromChar > toChar)
					{
						fieldsToCheck.Add(getFieldForaIntCharAndNum(fromChar - i, fromNum));
					}
					if (fromChar < toChar)
					{
						fieldsToCheck.Add(getFieldForaIntCharAndNum(fromChar + i, fromNum));
					}
				}
			}

			foreach (string field in fieldsToCheck)
			{
				if (boardPositions[field] != null)
				{
					return false;
				}
			}

			return true;
		}
	}
}
