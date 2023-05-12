using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Pieces.View;

namespace Chess_Game.Chessset.Boards.View
{
    public class GridView : MonoBehaviour
    {
        [SerializeField]
        SquareView squarePrefab = null;

        private SquareView[,] squares;

        private readonly Vector3 space = new Vector2(0.12f, 0.12f);

        public void Initialize(Board board)
        {
            CreateGrid(board);
        }

        private void CreateGrid(Board board)
        {
            int fileSize = board.FileSize.ToInt();
            int rankSize = board.RankSize.ToInt();

            squares = new SquareView[fileSize, rankSize];

            //市松模様にするための変数
            int checkerCount = 0;

            for (int file = 0; file < fileSize; file++)
            {
                for (int rank = 0; rank < rankSize; rank++)
                {
                    squares[file, rank] = CreateSquaresImage(file, rank, checkerCount);
                    checkerCount++;
                }
                checkerCount++;
            }
        }

        private SquareView CreateSquaresImage(int file, int rank, int checkerCount)
        {
            Vector3 nextPosition = new Vector3(file + space.x, rank + space.y, 0);

            SquareView square = squarePrefab.InstantiateSquareView(nextPosition,this.transform);

            ColorType colorType = (ColorType)((checkerCount % 2) + 1);
            square.ChangeColor(colorType);
           
            return square;
        }

        public void SetPiece(PieceView piece, BoardPosition boardPosition)
        {
            if (squares == null)
                throw new System.NullReferenceException("CreateGrid()を呼び出してから使用して下さい");

            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[rank-1,file-1].SetPiece(piece);
        }

        public void RemovePiece(BoardPosition boardPosition)
        {
            if (squares == null)
                throw new System.NullReferenceException("CreateGrid()を呼び出してから使用して下さい");

            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[rank - 1, file - 1].RemovePiece();
        }

    }

}
