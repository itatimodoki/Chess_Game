using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class File
    {
        public readonly static File Empty = new File(-99);
        public readonly static int Min = 1;
        public readonly static int Max = 8;

        private readonly int file;

        public File(int file)
        {
            if (file == -99)
            {
                this.file = -99;
                return;
            }

            if (file < Min)
                throw new System.ArgumentOutOfRangeException("File下限オーバー");

            if (file > Max)
                throw new System.ArgumentOutOfRangeException("File上限オーバー");

            this.file = file;
        }

        public int ToInt()
        {
            return file;
        }

        /// <summary>
        /// 範囲外になる場合はEmptyを返す
        /// </summary>
        public File SafetedAdd(int file)
        {
            int next = this.file + file;
            if (Max < next)
                return File.Empty;

            if (next < Min)
                return File.Empty;

            return new File(next);
        }
    }

}
