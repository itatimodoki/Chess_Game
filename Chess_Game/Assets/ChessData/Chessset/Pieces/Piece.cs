using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public class Piece
    {
        private static readonly Piece Empty = new Piece();

        private readonly PieceType pieceType;
        private readonly ColorType colorType;
        private readonly MovePositionList movePositionList;

        /// <summary>
        /// ç≈èâÇÃçsìÆÇ©
        /// </summary>
        private bool isInitialAction = true;

        public Piece(PieceType pieceType,ColorType colorType,MovePositionList movePositionList)
        {
            this.pieceType = pieceType;
            this.colorType = colorType;

            this.movePositionList = movePositionList;
        }

        public Piece()
        {
            this.pieceType = PieceType.Empty;
            this.colorType = ColorType.Empty;
            this.movePositionList = new MovePositionList();
        }

        public bool IsEmpty()
        {
            return this == Piece.Empty;
        }

        public Piece Remove()
        {
            return Piece.Empty;
        }

        public bool IsInitialAction()
        {
            return isInitialAction;
        }
    }
}