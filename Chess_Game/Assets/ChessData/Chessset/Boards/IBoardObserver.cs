using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public interface IBoardObserver
    {
        public void SetPieceNotify(Piece piece,BoardPosition boardPosition);

        public void RemovePieceNotify(BoardPosition boardPosition);
    }

}