using System;
using System.Collections.Generic;

namespace ChessCS
{
	class Pawn : Figure
	{
		public Pawn(ConsoleColor color)
		{
			Symbol = isUnixSystem() ? '♙' : 'P';
			Color = color;
		}

		public override bool isValidMove(Move move, Dictionary<string, Figure> boardPositions)
		{
            int fromNum = (int)(move.From[1]-'0');
			int toNum = (int)(move.To[1]-'0');

            int fieldsBetweenNum = Math.Abs(toNum - fromNum) - 1;
           
            if (fieldsBetweenNum == 1 && move.From[0] == move.To[0])
            {
                if (Color.Equals(ConsoleColor.White) && move.From[1] == '2' && move.To[1] == '4')
                {
                    return true;
                }
                else if (Color.Equals(ConsoleColor.Black) && move.From[1] == '7' && move.To[1] == '5')
                {
                    return true;
                }
                return false;
            }

            if (move.From[0] != move.To[0] && fieldsBetweenNum == 0)
            {
                try
                {
                    Figure figureFrom = boardPositions[move.From];
                    Figure figureTo = boardPositions[move.To];
                    if (figureFrom.Color != figureTo.Color)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            
            return true;
		}
	}
}
