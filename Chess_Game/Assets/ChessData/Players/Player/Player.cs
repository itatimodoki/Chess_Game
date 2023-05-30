using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Chess_Game.Chessset.Boards.View;


namespace Chess_Game.Players.Player
{
    public class Player : GamePlayer
    {
        [SerializeField]
        private GameObject pieceParentObject = null;

        /// <summary>
        /// クリックした場所を取得する処理
        /// </summary>
        public override BoardPosition Designation()
        {
            return GetSquareViewBoarPosition();
        }
        
        private BoardPosition GetSquareViewBoarPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin,(Vector2)ray.direction);

            if (hit.collider == null)
                return BoardPosition.Empty;
           
            SquareView target = hit.transform.GetComponent<SquareView>();

            return target.GetBoardPosition();
        }

        public override void Initialize(GamePlayer enemyPlayer)
        {
            base.enemyPlayer = enemyPlayer;

        }


    }
}
