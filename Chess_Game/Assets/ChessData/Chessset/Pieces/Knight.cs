using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public class Knight : Piece
    {
        public override PieceType PieceType => PieceType.Knight;
        public override TypeQuantity TypeQuantity => TypeQuantity.Knight;
        public override bool IsInitialAction { get; protected set; } = true;
    }
}
