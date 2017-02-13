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

			string message = null;

			while (!board.IsGameOver())
			{
				Console.Clear();
				Console.SetCursorPosition(0,1);
				renderHelper.Render(board, message);
				Move move = cmdHandler.getMove();
				try
				{
					board.handleMove(move);
					message = null;
				}
				catch (InvalidOperationException e)
				{
					message = e.Message;
				} 
			}

		}
	}
}
