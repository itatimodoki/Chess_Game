using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Board
    {
        private readonly Grid grid;
        public readonly File FileSize = new File(8);
        public readonly Rank RankSize = new Rank(8);

        public Board()
        {
            grid = new Grid(FileSize,RankSize);
        }

        private Board(Grid grid)
        {
            this.grid = grid;
        }

        public Board SetPiece(Piece piece,BoardPosition position)
        {
            return new Board( grid.SetPiece(piece, position));
        }

        public Piece GetPiece(BoardPosition position)
        {
            return grid.GetPiece(position);
        }

        public Square GetSquare(BoardPosition position)
        {
            return grid.GetSquare(position);
        }

        public Board RemovePiece(BoardPosition position)
        {
            return new Board(grid.Remove(position));
        }

    }
}
