using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public interface IBoardObserver
    {
        public void Notify(Square updateSquare);
    }

}