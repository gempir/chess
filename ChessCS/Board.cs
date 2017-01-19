using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Board
	{
		public Dictionary<string, Figure> BoardPositions = new Dictionary<string, Figure>();

		public Board()
		{
			initalizeBoard();
		}

		void initalizeBoard()
		{
			BoardPositions.Add("A8", new Bishop("dark"));
            BoardPositions.Add("B8", new Bishop("light"));
            BoardPositions.Add("C4", new Queen("dark"));
		}
	}
}
