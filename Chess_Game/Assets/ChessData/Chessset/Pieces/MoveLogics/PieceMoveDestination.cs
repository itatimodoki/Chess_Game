using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    /// <summary>
    /// ��̈ړ��\�惊�X�g
    /// </summary>
    public class PieceMoveDestination:IEnumerator
    {
        /// <summary>
        /// �ς���O�̐F�̏ꏊ��ێ�
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
        /// �F�ς����s���}�X�̈ʒu��list�𐶐�
        /// </summary>
        private List<BoardPosition> CreateChangePositionList(MovePositionList movePositionList, BoardPosition pieceBoardPosition)
        {
            var changePositionList = new List<BoardPosition>();

            foreach (MovePosition movePosition in movePositionList)
            {
                BoardPosition changePosition = MovePositionToBoardPosition(movePosition,pieceBoardPosition);
                changePositionList.Add(changePosition);
            }

            //���C���ňړ��\�ȕ�������
            //�����̋�ƓG�̋�𒴂������Ɖz�����Ȃ������


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
