using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Chess_Game.Chessset.Pieces
{
    public class King : Piece
    {
        public override PieceType PieceType => PieceType.King;
        public override TypeQuantity TypeQuantity => TypeQuantity.King;
        public override bool IsInitialAction { get; protected set; } = true;
    }

}
