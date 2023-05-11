using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class PawnMovePositionList : MovePositionList
    {
        /// <summary>
        /// ³ˆÊ’u‚Å‚Ì“Áê‚È‚à‚ÌˆÈŠO‚ÌˆÚ“®æ
        /// </summary>
        private readonly MovePosition[] movePositionsDate = new MovePosition[]
        {
            new MovePosition(1,0,false),
        };

        protected override MovePosition[] Create()
        {
            return movePositionsDate;
        }


    }

}
