using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Chess_Game
{
    public class BoardPosition
    {
        public readonly int file;
        public readonly int rank;

        public BoardPosition(int file, int rank)
        {
            if (file <= 0 || rank <= 0)
                throw new ArgumentOutOfRangeException("BoardPosition", "fileSize,rankSize エラー");

            this.file = file;
            this.rank = rank;
        }

        //加算
        public BoardPosition AddTo(int file,int rank)
        {
            int nextFile = this.file + file;
            int nextRank = this.rank + rank;
            if (nextFile <= 0 || nextRank <= 0)
                throw new ArgumentOutOfRangeException("BoardPosition", "fileSize,rankSize エラー");

            return new BoardPosition(nextFile, nextRank);
        }


    }
}
