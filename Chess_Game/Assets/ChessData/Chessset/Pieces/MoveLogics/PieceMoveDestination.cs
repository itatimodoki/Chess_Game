using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    /// <summary>
    /// 駒の移動可能先リスト
    /// </summary>
    public class PieceMoveDestination:IEnumerator
    {
        /// <summary>
        /// 変える前の色の場所を保持
        /// </summary>
        List<BoardPosition> changePositionList;

        public PieceMoveDestination(MovePositionList movePositionList, BoardPosition pieceBoardPosition)
        {
            changePositionList = CreateChangePositionList(movePositionList,pieceBoardPosition);
        }

        private int currPosition = -1;
        public object Current => changePositionList[currPosition];


        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            currPosition++;
            return (currPosition < changePositionList.Count);
        }

        public void Reset()
        {
            currPosition = -1;
        }

        /// <summary>
        /// 色変えを行うマスの位置のlistを生成
        /// </summary>
        private List<BoardPosition> CreateChangePositionList(MovePositionList movePositionList, BoardPosition pieceBoardPosition)
        {
            var changePositionList = new List<BoardPosition>();

            foreach (MovePosition movePosition in movePositionList)
            {
                BoardPosition changePosition = MovePositionToBoardPosition(movePosition,pieceBoardPosition);
                changePositionList.Add(changePosition);
            }

            //ラインで移動可能な物もある
            //自分の駒と敵の駒を超えられる駒と越えられない駒がある


            return changePositionList;
        }

        private BoardPosition MovePositionToBoardPosition(MovePosition movePosition,BoardPosition originPostion)
        {
            var toPositonFile = new File(originPostion.FileToInt());
            toPositonFile = toPositonFile.SafetedAdd(movePosition.FileRange);

            var toPositionRank = new Rank(originPostion.RankToInt());
            toPositionRank = toPositionRank.SafetedAdd(movePosition.RankRange);

            return new BoardPosition(toPositonFile, toPositionRank);
        }

        public bool IsEmpty()
        {
            return changePositionList.Count == 0;       
        }




    }
}
