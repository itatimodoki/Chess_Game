using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Players.Player
{
    public abstract class GamePlayer : MonoBehaviour
    {
         List<Pieces> myPieces = new List<Pieces>();

        public abstract Square GetSquare();

        public abstract void Initialize();

    }

}
