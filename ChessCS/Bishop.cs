using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Bishop : Figure
	{
		public Bishop(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♗' : 'B';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
			if (Board.getColorOfField(move.From) != Board.getColorOfField(move.To))
			{
				return false;
			}

			int fromChar = (int)move.From[0];
			int toChar = (int)move.To[0];

			int fromNum = (int)(move.From[1]-'0');
			int toNum = (int)(move.To[1]-'0');


			List<string> fieldsToCheck = new List<string>();

			int fieldsBetween = Math.Abs(toChar - fromChar) - 1;

			for (int i = 1; i <= fieldsBetween; i++)
			{
				if (toChar > fromChar && toNum > fromNum)
				{
					fieldsToCheck.Add(Char.ConvertFromUtf32((fromChar + i)) + (fromNum + i).ToString());
				}
				if (toChar < fromChar && toNum > fromNum)
				{
					fieldsToCheck.Add(Char.ConvertFromUtf32((fromChar - i)) + (fromNum + i).ToString());
				}
				if (toChar > fromChar && toNum < fromNum)
				{
					fieldsToCheck.Add(Char.ConvertFromUtf32((fromChar + i)) + (fromNum - i).ToString());
				}
				if (toChar < fromChar && toNum < fromNum)
				{
					fieldsToCheck.Add(Char.ConvertFromUtf32((fromChar - i)) + (fromNum - i).ToString());
				}
			}

			foreach (string field in fieldsToCheck)
			{
				if (boardPositions[field] != null) {
					return false;
				}
			}
			return true;
		}
	}
}
