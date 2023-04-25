using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public abstract class Piece : MonoBehaviour
    {
        /// <summary>
        /// ��̕���
        /// </summary>
        public abstract PieceType PieceType { get; }

        /// <summary>
        /// ��̕��ޖ��̐�
        /// </summary>
        public abstract TypeQuantity TypeQuantity { get; }

        /// <summary>
        /// �s������x�ł��s������
        /// </summary>
        public abstract bool IsInitialAction
        {
            protected set;
            get;
        }
    }
}