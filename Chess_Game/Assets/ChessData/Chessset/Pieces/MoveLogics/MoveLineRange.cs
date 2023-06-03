using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Players;
using Chess_Game.Chessset.Boards.View;
using Cysharp.Threading.Tasks;
using System.Threading;
using Chess_Game.Players.Player;


namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public class MoveLineRange:IEnumerator,IEnumerable
    {
        private readonly int maxRange =8;
        public object Current => moveRanges[currentPoint];
        private int currentPoint = -1;
        private readonly MoveRange[] moveRanges;

        public MoveLineRange(int fileDirection,int rankDirecton)
        {
            moveRanges = Create(fileDirection,rankDirecton);
        }

        private MoveRange[] Create(int fileDirection, int rankDirecton)
        {
            var moveRangeList = new List<MoveRange>();

            for(int range = 1;range <= maxRange;range++)
            {
                moveRangeList.Add(new MoveRange(fileDirection * range, rankDirecton * range));
            }
            return moveRangeList.ToArray();
        }

        public bool MoveNext()
        {
            currentPoint++;
            return currentPoint < moveRanges.Length;
        }

        public void Reset()
        {
            currentPoint = -1;
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return (IEnumerator)this;
        }
    }

}
