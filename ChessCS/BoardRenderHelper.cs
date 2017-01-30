using System;
namespace ChessCS
{
	class BoardRenderHelper
	{
		public BoardRenderHelper()
		{
			Console.WriteLine("");
		}

		// renders a full chess board to the console
		public void Render(Board board)
		{
			RenderEmptyBoard();

			foreach (var entry in board.BoardPositions)
			{
				Tuple<int, int> positions = GetCursorPositionsForField(entry.Key);
				Console.SetCursorPosition(positions.Item1, positions.Item2);
				PrintFigureToField(entry.Key, entry.Value);
			}

			// set cursor to bottom of console
			int x = Console.CursorLeft;
			int y = Console.CursorTop;
			Console.CursorTop = Console.WindowTop + Console.WindowHeight - 10;
			Console.SetCursorPosition(0, 11);
		}

		private void PrintFigureToField(string field, Figure figure)
		{
			string color = Board.getColorOfField(field);
			if (color == "dark")
			{
				Console.BackgroundColor = ConsoleColor.DarkGreen;
			}
			else if (color == "light")
			{
				Console.BackgroundColor = ConsoleColor.Green;
			}
			Console.ForegroundColor = figure.Color;
			Console.Write(figure);
			// reset color
			Console.ForegroundColor = ConsoleColor.White;
			Console.BackgroundColor = ConsoleColor.Black;
		}


		private Tuple<int, int> GetCursorPositionsForField(string field)
		{
			Char letter = field[0];
			Char number = field[1];

			int x, y;

			switch (letter)
			{
				case 'A':
					x = 1;
					break;
				case 'B':
					x = 3;
					break;
				case 'C':
					x = 5;
					break;
				case 'D':
					x = 7;
					break;
				case 'E':
					x = 9;
					break;
				case 'F':
					x = 11;
					break;
				case 'G':
					x = 13;
					break;
				case 'H':
					x = 15;
					break;
				default:
					x = 0;
					break;
			}
			switch (number)
			{
				case '1':
					y = 8;
					break;
				case '2':
					y = 7;
					break;
				case '3':
					y = 6;
					break;
				case '4':
					y = 5;
					break;
				case '5':
					y = 4;
					break;
				case '6':
					y = 3;
					break;
				case '7':
					y = 2;
					break;
				case '8':
					y = 1;
					break;
				default:
					y = 0;
					break;
			}

			return Tuple.Create(x, y);
		}

		private void RenderEmptyField(string color)
		{
			if (color == "light")
			{
				Console.BackgroundColor = ConsoleColor.Green;
			}
			else if (color == "dark")
			{
				Console.BackgroundColor = ConsoleColor.DarkGreen;
			}

			Console.Write("  ");
			Console.BackgroundColor = ConsoleColor.Black;
		}

		private void RenderEmptyBoard()
		{
			Console.Write("8");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			Console.Write("\r\n");
			Console.Write("7");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			Console.Write("\r\n");
			Console.Write("6");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			Console.Write("\r\n");
			Console.Write("5");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			Console.Write("\r\n");
			Console.Write("4");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			Console.Write("\r\n");
			Console.Write("3");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			Console.Write("\r\n");
			Console.Write("2");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			Console.Write("\r\n");
			Console.Write("1");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			RenderEmptyField("dark");
			RenderEmptyField("light");
			Console.Write("\r\n");
			Console.Write(" ");
			Console.Write("A ");
			Console.Write("B ");
			Console.Write("C ");
			Console.Write("D ");
			Console.Write("E ");
			Console.Write("F ");
			Console.Write("G ");
			Console.Write("H");
		}
			      
	}
}
