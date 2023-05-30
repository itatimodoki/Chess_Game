using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Players.Player;
using Cysharp.Threading.Tasks;
using System.Threading;
using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Boards.View;
using Chess_Game.Chessset.Pieces.MoveLogics;

namespace Chess_Game
{
    public class Turn
    {
        private readonly GamePlayer gamePlayer;
        private readonly GamePlayer enemyPlayer;

        public Turn(GamePlayer gamePlayer,GamePlayer enemyPlayer)
        {
            this.gamePlayer = gamePlayer;
            this.enemyPlayer = enemyPlayer;
        }

        public async UniTask Main(BoardView boardView,Board board,CancellationToken token)
        {
            //自分がチェックされていないか確認
            while (true)
            {
                //クリックした座標の取得
                await UniTask.WaitUntil(IsSquareClick, cancellationToken: token);

                BoardPosition clickPosition = gamePlayer.Designation();

                Piece piece = board.GetPiece(clickPosition);
                if (piece.PieceType == PieceType.Empty)
                {
                    continue;
                }

                Debug.Log($"{clickPosition.FileToInt()} {clickPosition.RankToInt()}");

                break;
            }
            Debug.Log($"{gamePlayer.name}");
            //チェックもしくはチェックメイトなら別の処理に移行
        }

        private bool IsSquareClick()
        {
            if (!Input.GetMouseButtonDown(0))
                return false;

            if (gamePlayer.Designation() == BoardPosition.Empty)
                return false;

            return true;
        }

        /// <summary>
        /// チェック（王手）されているか
        /// </summary>
        public bool IsCheck()
        {
            return false;
        }

        /// <summary>
        /// 次のプレイヤーのターンの作成
        /// </summary>
        public Turn Vacate()
        {
            return new Turn(enemyPlayer, gamePlayer);
        }
    }

}
