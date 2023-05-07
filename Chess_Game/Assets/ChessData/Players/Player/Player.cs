using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AddressableAssets;

namespace Chess_Game.Players.Player
{
    public class Player : GamePlayer
    {
        [SerializeField]
        private GameObject pieceParentObject = null;

        public void Start()
        {
            StartCoroutine( Initialize());
        }

        public override IEnumerator Initialize()
        {
            yield return null;
        }

        public override IEnumerator CreatePieceList()
        {
            return null;
        }

        public override Piece GetPiece()
        {
            throw new System.NotImplementedException();
        }
    }
}
