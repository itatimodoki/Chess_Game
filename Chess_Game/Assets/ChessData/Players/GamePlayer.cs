using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards;
using Chess_Game.Players;
using Cysharp.Threading.Tasks;

namespace Chess_Game.Players.Player
{
    public abstract class GamePlayer : MonoBehaviour
    {
        protected GamePlayer enemyPlayer;
        public abstract void Initialize(GamePlayer enemyPlayer);

        public abstract BoardPosition Designation();

    }

}
