using System;

namespace ChessCS
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Board board = new Board();
			BoardRenderHelper renderHelper = new BoardRenderHelper();
			CommandHandler cmdHandler = new CommandHandler();

			while (!board.IsGameOver())
			{
				Console.Clear();
				Console.SetCursorPosition(0,1);
				renderHelper.Render(board);
				Move move = cmdHandler.getMove();
				board.handleMove(move);
			}

		}
	}
}
