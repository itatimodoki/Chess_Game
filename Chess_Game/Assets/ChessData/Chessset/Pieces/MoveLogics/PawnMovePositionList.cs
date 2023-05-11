using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class PawnMovePositionList : MovePositionList
    {
        /// <summary>
        /// 正位置での特殊なもの以外の移動先
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
