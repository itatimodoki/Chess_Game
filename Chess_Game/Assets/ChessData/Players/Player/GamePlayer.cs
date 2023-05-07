using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards;
using Chess_Game.Players;

namespace Chess_Game.Players.Player
{
    public abstract class GamePlayer : MonoBehaviour
    {
        public abstract IEnumerator Initialize();

        public abstract IEnumerator CreatePieceList();

        public abstract Piece GetPiece();


    }

}
