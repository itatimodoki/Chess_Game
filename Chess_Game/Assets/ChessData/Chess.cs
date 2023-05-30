using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Players;
using Chess_Game.Chessset.Boards.View;
using Cysharp.Threading.Tasks;
using System.Threading;
using Chess_Game.Players.Player;


namespace Chess_Game
{
    public class Chess : MonoBehaviour
    {
        private Board board = new Board();

        [SerializeField]
        private GamePlayer Player1 = null;

        [SerializeField]
        private GamePlayer Player2 = null;

        [SerializeField]
        private BoardView boardView = null;

        private void Start()
        {
            ChesssetSetUp();
            PlayerSetUp();

            CancellationToken token = this.GetCancellationTokenOnDestroy();
            Main(token).Forget();
        }

        /// <summary>
        /// ボードと駒の初期化
        /// </summary>
        private void ChesssetSetUp()
        {
            PieceGenerator pieceGenerator = new PieceGenerator();
            List<Piece> blackPieceList = pieceGenerator.Create(ColorType.Black);
            List<Piece> whitePieceList = pieceGenerator.Create(ColorType.White);

            boardView.Initialize(board);

            PieceArranger pieceArranger = new PieceArranger();
            board = pieceArranger.BoardInPiece(board, blackPieceList, Side.Under);
            board = pieceArranger.BoardInPiece(board, whitePieceList, Side.Top);
        }

        /// <summary>
        /// プレイヤー双方の初期化
        /// </summary>
        private void PlayerSetUp()
        {
            //どちらが黒か白か決める
            //初期化
        }

        private async UniTask Main(CancellationToken token)
        {
            bool isGameEnd = false;
            var playTurn = new Turn(Player1, Player2);

            while (!isGameEnd)
            {
                await playTurn.Main(boardView,board,token);

                playTurn = playTurn.Vacate();
            }
        }



    }
}