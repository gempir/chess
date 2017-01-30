using System;
namespace ChessCS
{
	class Rook : Figure
	{
		public Rook(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♖' : 'R';
			Color = color;
		}

		public override bool isValidMove(Move move)
		{
			throw new NotImplementedException();
		}
	}
}
