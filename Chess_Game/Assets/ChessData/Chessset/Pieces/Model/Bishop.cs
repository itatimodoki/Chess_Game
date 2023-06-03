using Chess_Game.Chessset.Boards;
using Chess_Game.Players;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;

namespace Chess_Game.Chessset.Pieces.Model
{
    public class Bishop : Piece, IDestinationble
    {
        private readonly MoveLineRange[] moveLineRanges =
{
            new MoveLineRange(1,1),
            new MoveLineRange(-1,1),
            new MoveLineRange(-1,-1),
            new MoveLineRange(1,-1),
        };

        public Bishop(PieceType pieceType, ColorType colorType) : base(pieceType, colorType)
        {
            return;
        }

        public List<BoardPosition> GetDestination(Board board, BoardPosition basePosition, Side playSide)
        {
            var bishopMovePositions = new List<BoardPosition>();
            foreach (MoveLineRange moveLineRange in moveLineRanges)
            {
                BoardPosition[] line = Destination.LineDestinationCalculation(basePosition, moveLineRange, playSide);
                bishopMovePositions.AddRange(Destination.LineDestination(board, line, base.colorType));
            }
            return bishopMovePositions;
        }
    }

}
