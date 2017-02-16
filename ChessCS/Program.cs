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
