using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class MoveRange
    {
        public readonly int FileRange;
        public readonly int RankRange;

        public MoveRange(int fileRange, int rankRange)
        {
            this.FileRange = fileRange;
            this.RankRange = rankRange;
        }

        public MoveRange TurnOver()
        {
            int fileRange = this.FileRange * -1;
            int rankRange = this.RankRange * -1;
            return new MoveRange(fileRange, rankRange);
        }

    }
}
