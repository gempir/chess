using System;
namespace ChessCS
{
	class King : Figure
	{
		public King(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♔' : 'K';
			Color = color;
		}

		public override bool isValidMove(Move move)
		{
			throw new NotImplementedException();
		}
	}
}
