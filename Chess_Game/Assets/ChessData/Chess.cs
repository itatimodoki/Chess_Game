using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Players;
using Chess_Game.Chessset.Boards.View;

namespace Chess_Game
{
    public class Chess : MonoBehaviour
    {
        private Board board = new Board();

        [SerializeField]
        private BoardView boardView = null;

        private void Start()
        {
            ChesssetSetUp();
        }

        private void ChesssetSetUp()
        {
            PieceGenerator pieceGenerator = new PieceGenerator();
            List<Piece> blackPieceList =  pieceGenerator.Create(ColorType.Black);
            List<Piece> whitePieceList = pieceGenerator.Create(ColorType.White);

            boardView.Initialize(board);

            PieceArranger pieceArranger = new PieceArranger();
            board = pieceArranger.BoardInPiece(board, blackPieceList, Side.Under);

            board = pieceArranger.BoardInPiece(board, whitePieceList, Side.Top);
        }

    }
}