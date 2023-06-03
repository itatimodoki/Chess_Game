using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;
using Chess_Game.Chessset.Boards;
using System;

namespace Chess_Game.Chessset.Pieces
{
    public class Piece:IPiece
    {
        public static readonly Piece Empty = new Piece();

        protected readonly PieceType pieceType;
        protected readonly ColorType colorType;

        public bool IsFrstMove
        {
            private set;
            get;
        } = true;

        public Piece(PieceType pieceType = PieceType.Empty,ColorType colorType = ColorType.Empty)
        {
            this.pieceType = pieceType;
            this.colorType = colorType;
        }

        public ColorType GetColorType()
        {
            return colorType;
        }

        public PieceType GetPieceType()
        {
            return pieceType;
        }

        public void Action(Action action)
        {
            action();
            IsFrstMove = false;
        }
    }
}