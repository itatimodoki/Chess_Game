using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public abstract class MovePositionList : IEnumerable, IEnumerator
    {
        protected readonly MovePosition[] movePositions;
        private int currPosition = -1;
        public object Current => movePositions[currPosition];

        protected MovePositionList()
        {
            this.movePositions = Create();
        }

        public int Count()
        {
            return movePositions.Length;
        }

        protected abstract MovePosition[] Create();

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            currPosition++;
            return (currPosition < movePositions.Length);
        }

        public void Reset()
        {
            currPosition = -1;
        }
    }
}
