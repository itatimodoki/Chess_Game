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
        public override BoardPosition Designation()
        {
            return GetSquareViewBoarPosition();
        }

        private BoardPosition GetSquareViewBoarPosition()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit.collider == null)
                return BoardPosition.Empty;

            SquareView target = hit.transform.GetComponent<SquareView>();

            return target.GetBoardPosition();
        }

        public override void Initialize(ColorType colorType,Side playSide)
        {
           // base.enemyPlayer = enemyPlayer;
            base.myPieceColor = colorType;
            base.playSide = playSide;
        }


    }
}
