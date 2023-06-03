using Chess_Game.Chessset.Boards;
using Chess_Game.Players;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;

namespace Chess_Game.Chessset.Pieces.Model
{
    public class Knight : Piece, IDestinationble
    {
        private readonly MoveRange[] moveRanges =
        {
            new MoveRange(2,1),
            new MoveRange(1,2),
            new MoveRange(-1,2),
            new MoveRange(-2,1),
            new MoveRange(-2,-1),
            new MoveRange(-1,-2),
            new MoveRange(1,-2),
            new MoveRange(2,-1),
        };

        public Knight(PieceType pieceType, ColorType colorType) : base(pieceType, colorType)
        {
            return;
        }

        public List<BoardPosition> GetDestination(Board board, BoardPosition basePosition, Side playSide)
        {
            BoardPosition[] tryKnightMovePositions = Destination.DestinationCalculations(basePosition, moveRanges, playSide);
            var destinationBoardPositions = new List<BoardPosition>();

            foreach (var boardPosition in tryKnightMovePositions)
            {
                if (boardPosition.IsEmpty())
                    continue;

                IPiece piece = board.GetPiece(boardPosition);
                if (this.GetColorType() == piece.GetColorType())
                    continue;

                destinationBoardPositions.Add(boardPosition);
            }

            return destinationBoardPositions;
        }
    }

}
