using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Square
    {
        private static readonly Square Empty = new Square();
        private readonly IPiece holdPiece;

        public Square(IPiece piece)
        {
            holdPiece = piece;
        }

        public Square()
        {
            holdPiece = Piece.Empty;
        }

        public bool IsEmpty()
        {
            return this == Empty;
        }

        public IPiece GetPiece()
        {
            return holdPiece;
        }

        
    }

}
