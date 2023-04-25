using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chess_Game.Chessset.Pieces
{
    public class Pawn : Piece
    {
        public override PieceType PieceType => PieceType.Pawn;
        public override TypeQuantity TypeQuantity => TypeQuantity.Pawn;
        public override bool IsInitialAction { get; protected set; } = true;
    }
}