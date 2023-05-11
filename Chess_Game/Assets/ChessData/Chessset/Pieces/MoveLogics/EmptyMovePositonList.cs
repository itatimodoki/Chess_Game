using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class EmptyMovePositonList : MovePositionList
    {
        protected override MovePosition[] Create()
        {
            return Array.Empty<MovePosition>();
        }
    }

}