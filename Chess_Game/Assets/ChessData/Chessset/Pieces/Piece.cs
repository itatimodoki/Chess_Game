using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public abstract class Piece : MonoBehaviour
    {
        /// <summary>
        /// ‹î‚Ì•ª—Ş
        /// </summary>
        public abstract PieceType PieceType { get; }

        /// <summary>
        /// ‹î‚Ì•ª—Ş–ˆ‚Ì”
        /// </summary>
        public abstract TypeQuantity TypeQuantity { get; }

        /// <summary>
        /// s“®‚ğˆê“x‚Å‚às‚Á‚½‚©
        /// </summary>
        public abstract bool IsInitialAction
        {
            protected set;
            get;
        }
    }
}