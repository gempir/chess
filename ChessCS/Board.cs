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
			// white
			BoardPositions.Add("A1", new Rook(ConsoleColor.White));
			BoardPositions.Add("B1", new Knight(ConsoleColor.White));
			BoardPositions.Add("C1", new Bishop(ConsoleColor.White));
			BoardPositions.Add("D1", new Queen(ConsoleColor.White));
			BoardPositions.Add("E1", new King(ConsoleColor.White));
			BoardPositions.Add("F1", new Bishop(ConsoleColor.White));
			BoardPositions.Add("G1", new Knight(ConsoleColor.White));
			BoardPositions.Add("H1", new Rook(ConsoleColor.White));

			BoardPositions.Add("A2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("B2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("C2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("D2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("E2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("F2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("G2", new Pawn(ConsoleColor.White));
			BoardPositions.Add("H2", new Pawn(ConsoleColor.White));

			// black
			BoardPositions.Add("A8", new Rook(ConsoleColor.Black));
			BoardPositions.Add("B8", new Knight(ConsoleColor.Black));
			BoardPositions.Add("C8", new Bishop(ConsoleColor.Black));
			BoardPositions.Add("D8", new Queen(ConsoleColor.Black));
			BoardPositions.Add("E8", new King(ConsoleColor.Black));
			BoardPositions.Add("F8", new Bishop(ConsoleColor.Black));
			BoardPositions.Add("G8", new Knight(ConsoleColor.Black));
			BoardPositions.Add("H8", new Rook(ConsoleColor.Black));

			BoardPositions.Add("A7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("B7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("C7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("D7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("E7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("F7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("G7", new Pawn(ConsoleColor.Black));
			BoardPositions.Add("H7", new Pawn(ConsoleColor.Black));
		}
	}
}
