using Chess_Game.Chessset.Boards;
using Chess_Game.Players;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;

namespace Chess_Game.Chessset.Pieces.Model
{
    public class King : Piece, IDestinationble
    {
        readonly MoveRange[] moveRanges =
        {
            new MoveRange(1,0),
            new MoveRange(1,1),
            new MoveRange(-1,1),
            new MoveRange(-1,0),
            new MoveRange(-1,-1),
            new MoveRange(0,-1),
            new MoveRange(1,-1),
            new MoveRange(0,1),
        };

        public King(PieceType pieceType, ColorType colorType) : base(pieceType, colorType)
        {
            return;
        }

        public List<BoardPosition> GetDestination(Board board, BoardPosition basePosition, Side playSide)
        {
            BoardPosition[] tryKingMovePositions = Destination.DestinationCalculations(basePosition,moveRanges,playSide);
            var destinationBoardPositions = new List<BoardPosition>();

            foreach (var boardPosition in tryKingMovePositions)
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
