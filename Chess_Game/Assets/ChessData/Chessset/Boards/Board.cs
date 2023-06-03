using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Board:Subject
    {
        private Grid grid;
        public readonly File FileSize = new File(8);
        public readonly Rank RankSize = new Rank(8);

        public Board()
        {
            grid = new Grid(FileSize, RankSize);
        }

        public void SetPiece(IPiece piece, BoardPosition position)
        {
            grid.SetPiece(piece, position);
            base.SetPieceNotifyObservers(piece, position);
        }

        public IPiece GetPiece(BoardPosition position)
        {
            return grid.GetPiece(position);
        }

        public void PieceMove(BoardPosition moveTargetPosition,BoardPosition nextPosition)
        {
            IPiece movePiece = GetPiece(moveTargetPosition);

            movePiece.Action(() => 
            {
                if (movePiece.GetPieceType() == PieceType.Empty)
                {
                    throw new System.ArgumentException("ˆÚ“®‚³‚¹‚é‹î‚ª‚ ‚è‚Ü‚¹‚ñ");
                }

                IPiece nextPositionPieceState = GetPiece(nextPosition);
                if (nextPositionPieceState.GetPieceType() != PieceType.Empty)
                {
                    RemovePiece(nextPosition);
                }

                SetPiece(movePiece, nextPosition);
                RemovePiece(moveTargetPosition);
            });
        }

        public Square GetSquare(BoardPosition position)
        {
            return grid.GetSquare(position);
        }

        public void RemovePiece(BoardPosition position)
        {
            grid.Remove(position);
            RemovePieceNotifyObservers(position);
        }
    }
}
