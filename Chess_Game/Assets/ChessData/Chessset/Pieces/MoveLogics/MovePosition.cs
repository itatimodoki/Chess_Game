using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class MovePosition
    {
        public readonly int FileRange;
        public readonly int RankRange;
        public readonly bool isLine;
        public MovePosition(int fileRange,int rankRange,bool isLine)
        {

            this.FileRange = fileRange;
            this.RankRange = rankRange;

            this.isLine = isLine;
        }


    }
}