using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Square
    {
        private static readonly Square Empty = new Square();
        private readonly Piece holdPiece;

        public Square(Piece piece)
        {
            holdPiece = piece;
        }

        public Square()
        {
            holdPiece = new Piece();
        }

        public bool IsEmpty()
        {
            return this == Empty;
        }

        public Piece GetPiece()
        {
            return holdPiece;
        }

        
    }

}
