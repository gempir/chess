using System;
namespace ChessCS
{
	class Bishop : Figure
	{
		public Bishop(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♗' : 'B';
			Color = color;
		}

		public override bool isValidMove(Move move)
		{
			if (move.From[1] == move.To[1] || move.From[0] == move.To[0])
			{
				return false;
			}
			if (move.From == move.To)
			{
				return false;
			}
			if (Board.getColorOfField(move.From) != Board.getColorOfField(move.To))
			{
				return false;
			}
			return true;
		}
	}
}
