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
			if (move.From[1] == move.To[1] || move.From[0] == move.To[0])
			{
				return false;
			}
			if (move.From == move.To)
			{
				return false;
			}
			if (Board.getColorOfField(move.From) != Board.getColorOfField(move.To))
			{
				return false;
			}

			int fromChar, currentChar;
			fromChar = currentChar = (int)move.From[0];
			int toChar = (int)move.To[0];

			int fromNum, currentNum;
			fromNum = currentNum = (int)move.From[1];
			int toNum = (int)move.To[0];


			List<string> fieldList = new List<string>();

			while (toChar != currentChar || toNum != currentNum)
			{
				Console.WriteLine(currentChar);
				string searchChar, searchNum;
				if (toChar > fromChar)
				{
					searchChar = Char.ConvertFromUtf32(currentChar++);
					currentChar++;
				}
				else {
					searchChar = Char.ConvertFromUtf32(currentChar--);
					currentChar--;
				}
				if (toNum > fromNum)
				{
					searchNum = currentNum++.ToString();
					currentNum++;
				}
				else {
					searchNum = currentNum--.ToString();
					currentNum--;
				}

				fieldList.Add(searchChar + searchNum);
			}

			foreach (string field in fieldList)
			{
				if (boardPositions[field] == null)
				{
					continue;
				}
				return false;
			}
			return true;
		}
	}
}
