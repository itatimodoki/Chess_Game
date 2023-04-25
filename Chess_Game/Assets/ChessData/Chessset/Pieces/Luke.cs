using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public class Luke : Piece
    {
        public override PieceType PieceType => PieceType.Luke;
        public override TypeQuantity TypeQuantity => TypeQuantity.Luke;
        public override bool IsInitialAction { get; protected set; } = true;
    }
}
