using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Chess_Game.Chessset.Pieces.View;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards.View
{
    public class BoardView : MonoBehaviour, IBoardObserver
    {
        [SerializeField]
        PieceView pieceView = null;

        [SerializeField]
        GridView gridView = null;

        public void Initialize(Board board)
        {
            gridView.Initialize(board);
            board.AddObserver(this);
        }

        public void SetPieceNotify(IPiece piece, BoardPosition boardPosition)
        {
            SetPiece(piece, boardPosition);
        }

        private void SetPiece(IPiece piece,BoardPosition boardPosition)
        {
            PieceView instancePiece = pieceView.InstancePiece(piece.GetPieceType(), piece.GetColorType());
            gridView.SetPiece(instancePiece, boardPosition);
        }

        public void RemovePiece(BoardPosition boardPosition)
        {
            gridView.RemovePiece(boardPosition);
        }

        public void RemovePieceNotify(BoardPosition boardPosition)
        {
            gridView.RemovePiece(boardPosition);
        }

        public void SquareChangeColor(BoardPosition boardPosition, SquareColorType colorType)
        {
            gridView.SquareChangeColor(boardPosition, colorType);
        }

        public void SquareColorReset(BoardPosition boardPosition)
        {
            gridView.SquareColorReset(boardPosition);
        }
    }

}
