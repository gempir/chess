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
			// bishop-like
			int fromChar = (int)move.From[0];
			int toChar = (int)move.To[0];

			int fromNum = (int)(move.From[1] - '0');
			int toNum = (int)(move.To[1] - '0');


			List<string> fieldsToCheck = new List<string>();

			int fieldsBetween = Math.Abs(toChar - fromChar) - 1;


			if (fromNum != toNum && fromChar != toChar)
			{
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
			}
			else 
			{
				if (fromNum != toNum)
					{
						int fieldsBetweenRook = Math.Abs(toNum - fromNum) - 1;

						for (int i = 1; i <= fieldsBetweenRook; i++)
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
						int fieldsBetweenRook = Math.Abs(fromChar - toChar) - 1;

						for (int i = 1; i <= fieldsBetweenRook; i++)
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
			}


			foreach (string field in fieldsToCheck)
			{
				try
				{
					if (boardPositions[field] != null)
					{
						return false;
					}
				}
				catch (KeyNotFoundException)
				{

				}
			}

			return true;
		}
	}
}
