using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces
{
    public class MovePosition
    {
        private readonly File fileRange;
        private readonly Rank rankRange;
        private readonly bool isLine;

        public MovePosition(File fileRange,Rank rankRange,bool isLine)
        {
            this.fileRange = fileRange;
            this.rankRange = rankRange;
            this.isLine = isLine;
        }
    }
}