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
using System.Linq;

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
            //�������`�F�b�N����Ă��Ȃ����m�F
            while (true)
            {
                //�N���b�N�������W�̎擾
                await UniTask.WaitUntil(IsSquareClick, cancellationToken: token);
                BoardPosition clickPosition = gamePlayer.Designation();

                //����邩
                IPiece piece = board.GetPiece(clickPosition);
                if (piece.GetPieceType() == PieceType.Empty)
                {
                    continue;
                }

                //��͎����̋
                if(piece.GetColorType() != gamePlayer.GetColorType())
                {
                    continue;
                }

                //�ړ��ł���Ȃ�\��
                var pieceMoveDestinationView = new PieceMoveDestinationView(boardView);
                List<BoardPosition> destinations = ((IDestinationble)piece).GetDestination(board, clickPosition,gamePlayer.GetPlaySide());
                int count = 0;
                foreach (BoardPosition destinationble in destinations)
                {
                    count++;
                    pieceMoveDestinationView.ViewUpdate(destinationble);
                }
                if (count == 0)
                    continue;

                //�s�[�X�̈ړ�
                //�N���b�N�������W�̎擾
                await UniTask.WaitUntil(IsSquareClick, cancellationToken: token);
                BoardPosition destinationClickPosition = gamePlayer.Designation();

                Debug.Log($"{clickPosition.FileToInt()} {clickPosition.RankToInt()}");
                Debug.Log($"{destinationClickPosition.FileToInt()} {destinationClickPosition.RankToInt()}");

                //�������ړ��\�悾������s�[�X���ړ��A����ȊO�Ȃ��蒼��
                if (!destinations.Exists(bp => destinationClickPosition.Comparison(bp)))
                    continue;

                board.PieceMove(clickPosition, destinationClickPosition);

                pieceMoveDestinationView.Reset();




                break;
            }
            Debug.Log($"{gamePlayer.name}");
            //�`�F�b�N�������̓`�F�b�N���C�g�Ȃ�ʂ̏����Ɉڍs
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
        /// �`�F�b�N�i����j����Ă��邩
        /// </summary>
        public bool IsCheck()
        {
            return false;
        }

        /// <summary>
        /// ���̃v���C���[�̃^�[���̍쐬
        /// </summary>
        public Turn Vacate()
        {
            return new Turn(enemyPlayer, gamePlayer);
        }
    }

}
