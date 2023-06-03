using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class Rank
    {
        public readonly static Rank Empty = new Rank(-99);
        public readonly static int Min = 1;
        public readonly static int Max = 8;

        private readonly int rank;

        public Rank(int rank)
        {
            if(rank == -99)
            {
                this.rank = rank;
                return;
            }

            if (rank < Min)
                throw new System.ArgumentOutOfRangeException("下限オーバー");

            if (rank > Max)
                throw new System.ArgumentOutOfRangeException("上限オーバー");

            this.rank = rank;
        }

        public int ToInt()
        {
            return rank;
        }

        /// <summary>
        /// 範囲外になる場合はEmptyを返す
        /// </summary>
        /// <param name="rank"></param>
        /// <returns></returns>
        public Rank SafetedAdd(int rank)
        {
            int next = this.rank + rank;

            if (next < Min || Max < next)
                return Rank.Empty;

            return new Rank(next);
        }

        public bool IsEmpty()
        {
            return rank == Empty.ToInt();
        }
    }

}
