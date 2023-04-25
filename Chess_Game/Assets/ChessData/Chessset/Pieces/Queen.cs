using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Pieces
{
    public class Queen : Piece
    {
        public override PieceType PieceType => PieceType.Queen;
        public override TypeQuantity TypeQuantity => TypeQuantity.Queen;
        public override bool IsInitialAction { get; protected set; } = true;
    }

}
