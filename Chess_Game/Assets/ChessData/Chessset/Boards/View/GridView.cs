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

            //ésèºñÕólÇ…Ç∑ÇÈÇΩÇﬂÇÃïœêî
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
            var nextPosition = new Vector3(rank + space.x, file + space.y, 0);
            var nextBoardPosition = new BoardPosition(new File(file + 1), new Rank(rank + 1));

            SquareColorType colorType = (SquareColorType)(checkerCount % 2);
            SquareView square = squarePrefab.InstantiateSquareView(nextPosition, nextBoardPosition, this.transform, colorType);

            return square;
        }

        public void SetPiece(PieceView piece, BoardPosition boardPosition)
        {
            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[file - 1, rank - 1].SetPiece(piece);
        }

        public void RemovePiece(BoardPosition boardPosition)
        {
            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[file - 1, rank - 1].RemovePiece();
        }

        public void SquareChangeColor(BoardPosition boardPosition, SquareColorType colorType)
        {
            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[file - 1, rank - 1].ChangeColor(colorType);
        }

        public void SquareColorReset(BoardPosition boardPosition)
        {
            int file = boardPosition.FileToInt();
            int rank = boardPosition.RankToInt();

            squares[file - 1, rank - 1].ResetColor();
        }
    }

}
