using System;

namespace ChessCS
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Board board = new Board();
			BoardRenderHelper renderHelper = new BoardRenderHelper();

			renderHelper.Render(board);
		}
	}
}
