using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class BishopMovePositionList : MovePositionList
    {
        private readonly MovePosition[] movePositionsDate = new MovePosition[]
        {
            new MovePosition(8,8,true),
            new MovePosition(-8,-8,true),
            new MovePosition(-8,8,true),
            new MovePosition(8,-8,true),
        };

        protected override MovePosition[] Create()
        {
            return movePositionsDate;
        }
    }
}