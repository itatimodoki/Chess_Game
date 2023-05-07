using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class BoardPosition
    {
        private readonly File file;
        private readonly Rank rank;
        public BoardPosition(File file,Rank rank)
        {
            this.file = file;
            this.rank = rank;
        }

        public int FileToInt()
        {
            return file.ToInt();
        }

        public int RankToInt()
        {
            return rank.ToInt();
        }
    }
}
