﻿using System;
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

		/// <summary>
		/// Will validate the move and change the positions of the figures on the board
		/// will throw an InvalidOperationException when the move is invalid
		/// </summary>
		/// <param name="move">Move.</param>
		public void handleMove(Move move)
		{
			Figure from = getFigureFromField(move.From);
			Figure to = getFigureFromField(move.To);

			if (
				from != null 
				&& CommandHandler.isActive(from.Color)
				&& isEmptyOrOpponent(to)
				&& from.isValidMove(move, BoardPositions)
			)
			{
				BoardPositions[move.From] = null;
				BoardPositions[move.To] = from;
			}
			else {
				throw new InvalidOperationException("Invalid move");
			}
			CommandHandler.ActiveColor = CommandHandler.ActiveColor == ConsoleColor.White ? ConsoleColor.Black : ConsoleColor.White;
		}

		private bool isEmptyOrOpponent(Figure to)
		{
			if (to == null)
			{
				return true;
			}
			if (to.Color == CommandHandler.ActiveColor)
			{
				return false;
			}
			return true;
		}

		private Figure getFigureFromField(string field)
		{
			try
			{
				return BoardPositions[field];
			}
			catch (Exception)
			{
				return null;
			}
		}

		public bool IsGameOver()
		{
			return false;
		}

		/// <summary>
		/// Check if a field is light or dark color
		/// </summary>
		/// <returns>The color of field.</returns>
		/// <param name="field">Field.</param>
		public static string getColorOfField(string field)
		{
			int number = int.Parse(field[1] + "");

			switch (field[0])
			{
				case 'A':
					return IsOdd(number) ? "dark" : "light";
				case 'B':
					return IsOdd(number) ? "light" : "dark";
				case 'C':
					return IsOdd(number) ? "dark" : "light";
				case 'D':
					return IsOdd(number) ? "light" : "dark";
				case 'E':
					return IsOdd(number) ? "dark" : "light";
				case 'F':
					return IsOdd(number) ? "light" : "dark";
				case 'G':
					return IsOdd(number) ? "dark" : "light";
				case 'H':
					return IsOdd(number) ? "light" : "dark";
				default:
					throw new Exception("Field Unkown");

			}
		}

		private void initalizeBoard()
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

		private static bool IsOdd(int value)
		{
			return value % 2 != 0;
		}

}
}
