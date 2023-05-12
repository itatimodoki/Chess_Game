using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Board:Subject
    {
        private  Grid grid;
        public readonly File FileSize = new File(8);
        public readonly Rank RankSize = new Rank(8);

        public Board()
        {
            grid = new Grid(FileSize, RankSize);
        }

        public void SetPiece(Piece piece, BoardPosition position)
        {
            grid.SetPiece(piece, position);
            base.PieceNotifyObservers(piece, position);
        }

        public Piece GetPiece(BoardPosition position)
        {
            return grid.GetPiece(position);
        }

        public Square GetSquare(BoardPosition position)
        {
            return grid.GetSquare(position);
        }

        public void RemovePiece(BoardPosition position)
        {
            grid.Remove(position);
        }

    }
}
