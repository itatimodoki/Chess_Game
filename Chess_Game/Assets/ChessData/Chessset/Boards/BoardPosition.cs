using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class BoardPosition
    {
        public static readonly BoardPosition Empty = new BoardPosition(File.Empty,Rank.Empty);
        private readonly File File;
        private readonly Rank Rank;
        public BoardPosition(File file,Rank rank)
        {
            this.File = file;
            this.Rank = rank;
        }

        public int FileToInt()
        {
            return File.ToInt();
        }

        public int RankToInt()
        {
            return Rank.ToInt();
        }

    }
}
