using System;
namespace ChessCS
{
	class Knight : Figure
	{
		public Knight(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♘' : 'N';
			Color = color;
		}

		public override bool isValidMove(Move move)
		{
			throw new NotImplementedException();
		}
	}
}
