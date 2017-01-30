using System;
namespace ChessCS
{
	class Queen : Figure
	{
		public Queen(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♕' : 'Q';
			Color = color;
		}

		public override bool isValidMove(Move move)
		{
			throw new NotImplementedException();
		}
	}
}
