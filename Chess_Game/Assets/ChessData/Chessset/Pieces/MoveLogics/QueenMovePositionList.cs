using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class QueenMovePositionList : MovePositionList
    {
        private readonly MovePosition[] movePositionsDate = new MovePosition[]
        {
            new MovePosition(8,0,true),
            new MovePosition(8,8,true),
            new MovePosition(0,8,true),
            new MovePosition(-8,8,true),
            new MovePosition(-8,0,true),
            new MovePosition(-8,-8,true),
            new MovePosition(0,-8,true),
            new MovePosition(8,-8,true),

        };

        protected override MovePosition[] Create()
        {
            return movePositionsDate;
        }
    }
}