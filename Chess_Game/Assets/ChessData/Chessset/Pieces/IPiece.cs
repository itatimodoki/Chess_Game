using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using System;

namespace Chess_Game.Chessset.Pieces
{
    public interface IPiece
    {
        public bool IsFrstMove { get; }
        public PieceType GetPieceType();

        public ColorType GetColorType();

        public void Action(Action action);
    }
}