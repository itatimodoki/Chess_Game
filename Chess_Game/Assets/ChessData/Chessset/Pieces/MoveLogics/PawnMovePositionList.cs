using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class PawnMovePositionList : MovePositionList
    {
        /// <summary>
        /// ���ʒu�ł̓���Ȃ��̈ȊO�̈ړ���
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
