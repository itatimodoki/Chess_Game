using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class KingMovePositionList : MovePositionList
    {
        private readonly MovePosition[] movePositionsDate = new MovePosition[]
        {
            new MovePosition(1,0,false),
            new MovePosition(1,1,false),
            new MovePosition(0,1,false),
            new MovePosition(-1,1,false),
            new MovePosition(-1,0,false),
            new MovePosition(-1,-1,false),
            new MovePosition(0,-1,false),
            new MovePosition(1,-1,false),

        };
        protected override MovePosition[] Create()
        {
            return movePositionsDate;
        }
    }
}