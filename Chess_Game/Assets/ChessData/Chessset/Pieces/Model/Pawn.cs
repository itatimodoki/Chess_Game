using Chess_Game.Chessset.Boards;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;
using System.Linq;
using Chess_Game.Players;

namespace Chess_Game.Chessset.Pieces.Model
{
    public class Pawn : Piece, IDestinationble
    {
        MoveRange moveRange = new MoveRange(1, 0);
        MoveRange firstMoveRange = new MoveRange(2, 0);
        MoveRange[] enemyPieceKillMoveRange = new MoveRange[]
        {
            new MoveRange(1, -1),
            new MoveRange(1, 1),
        };

        public Pawn(PieceType pieceType, ColorType colorType) : base(pieceType, colorType)
        {
            return;
        }

        public List<BoardPosition> GetDestination(Board board, BoardPosition basePosition,Side playSide)
        {
            var destinationBoardPositions = new List<BoardPosition>();

            BoardPosition front = Destination.DestinationCalculation(basePosition, moveRange,playSide);
            BoardPosition frstMove = Destination.DestinationCalculation(basePosition, firstMoveRange,playSide);

            destinationBoardPositions.AddRange(DiagonallyFront(board, basePosition,playSide));

            //正面
            if (board.GetPiece(front) != Piece.Empty)
            {
                return destinationBoardPositions;
            }
            destinationBoardPositions.Add(front);

            //初動時の移動可能先
            if (board.GetPiece(frstMove) != Piece.Empty || !IsFrstMove)
            {
                return destinationBoardPositions;
            }
            destinationBoardPositions.Add(frstMove);

            return destinationBoardPositions;
        }

        /// <summary>
        /// 斜め前
        /// </summary>
        private IList<BoardPosition> DiagonallyFront(Board board, BoardPosition basePosition,Side playSide)
        {
            var destinationBoardPositions = new List<BoardPosition>();
            BoardPosition[] diagonallyFront = Destination.DestinationCalculations(basePosition, enemyPieceKillMoveRange,playSide);

            //斜め前に相手の駒があれば         
            foreach (BoardPosition bp in diagonallyFront)
            {
                IPiece piece = board.GetPiece(bp);
                if (piece == Piece.Empty)
                    continue;

                if (this.GetColorType() == piece.GetColorType())
                    continue;

                destinationBoardPositions.Add(bp);
            }

            return destinationBoardPositions;
        }




    }

}
