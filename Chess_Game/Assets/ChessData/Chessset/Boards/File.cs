using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class File
    {
        public readonly static int Min = 1;
        public readonly static int Max = 8;

        private readonly int file;

        public File(int file)
        {
            if (file < Min)
                throw new System.ArgumentOutOfRangeException();

            if (file > Max)
                throw new System.ArgumentOutOfRangeException();

            this.file = file;
        }

        public int ToInt()
        {
            return file;
        }
    }

}
