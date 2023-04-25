using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chess_Game.Chessset.Pieces
{
    public class Bishop:Piece
    {
        public override PieceType PieceType => PieceType.Bishop;
        public override TypeQuantity TypeQuantity => TypeQuantity.Bishop;
        public override bool IsInitialAction { get; protected set; } = true;
    }

}
