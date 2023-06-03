using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class BoardPosition
    {
        public static readonly BoardPosition Empty = new BoardPosition(File.Empty,Rank.Empty);
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

        public  bool IsEmpty()
        {
            return file.IsEmpty() || rank.IsEmpty();
        }
        
        //ëŒè€Ç∆ìØÇ∂Ç©î‰är
        public bool Comparison(BoardPosition boardPosition)
        {
            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            return this.file.ToInt() == file && this.rank.ToInt() == rank;
        }

    }
}
