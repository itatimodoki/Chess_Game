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
        protected ColorType myPieceColor;
        protected Side playSide;

        public abstract void Initialize(ColorType colorType,Side playSide);

        public abstract BoardPosition Designation();

        public ColorType GetColorType()
        {
            return myPieceColor;
        }

        public Side GetPlaySide()
        {
            return playSide;
        }
    }

}
