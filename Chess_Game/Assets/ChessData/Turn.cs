using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Players.Player;

namespace Chess_Game
{
    public class Turn
    {
        private readonly GamePlayer gamePlayer;
        public Turn(GamePlayer gamePlayer)
        {
            this.gamePlayer = gamePlayer;
        }

        public IEnumerator Start()
        {
            yield return null;
        }

        public IEnumerator End()
        {
            yield return null;
        }
    }

}
