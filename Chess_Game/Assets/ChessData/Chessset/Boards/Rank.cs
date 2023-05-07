using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class Rank
    {
        public readonly static int Min = 1;
        public readonly static int Max = 8;

        private readonly int rank;

        public Rank(int rank)
        {
            if (rank < Min)
                throw new System.ArgumentOutOfRangeException();

            if (rank > Max)
                throw new System.ArgumentOutOfRangeException();

            this.rank = rank;
        }

        public int ToInt()
        {
            return rank;
        }
    }

}
