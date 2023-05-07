using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public class MovePositionList
    {
        private readonly List< MovePosition> movePositions;

        private MovePositionList(List<MovePosition> movePositions)
        {
            this.movePositions = movePositions;
        }

        public MovePositionList()
        {
            movePositions = new List<MovePosition>();
        }

        public MovePositionList Add(MovePosition movePosition)
        {
            List<MovePosition> next = new List<MovePosition>(movePositions);
            next.Add(movePosition);
            return new MovePositionList(next);
        }
    }

}
