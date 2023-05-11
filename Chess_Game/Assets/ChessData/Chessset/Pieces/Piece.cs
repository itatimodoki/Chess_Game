using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces
{
    public class Piece
    {
        private static readonly Piece Empty = new Piece();

        public readonly PieceType PieceType;
        public readonly ColorType ColorType;
        private readonly MovePositionList movePositionList;
        private BoardPosition startPosition;

        public Piece(PieceType pieceType,ColorType colorType,MovePositionList movePositionList)
        {
            this.PieceType = pieceType;
            this.ColorType = colorType;
            this.movePositionList = movePositionList;
        }

        public Piece()
        {
            this.PieceType = PieceType.Empty;
            this.ColorType = ColorType.Empty;
            this.movePositionList = new EmptyMovePositonList();
        }

        public bool IsEmpty()
        {
            return this == Piece.Empty;
        }

        public void SetStartPositon(BoardPosition startPosition)
        {
            this.startPosition = startPosition;
        }

    }
}