using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public abstract class Piece : MonoBehaviour
    {
        /// <summary>
        /// 駒の分類
        /// </summary>
        public abstract PieceType PieceType { get; }

        /// <summary>
        /// 駒の分類毎の数
        /// </summary>
        public abstract TypeQuantity TypeQuantity { get; }

        /// <summary>
        /// 行動を一度でも行ったか
        /// </summary>
        public abstract bool IsInitialAction
        {
            protected set;
            get;
        }
    }
}