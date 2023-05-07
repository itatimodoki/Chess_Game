using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chess_Game.Chessset.Boards.View
{
    public class GridView : MonoBehaviour
    {
        [SerializeField]
        Image square = null;

        [SerializeField]
        private readonly Color32 whiteSquaresColor = new Color32(205, 161, 111, 255);
        [SerializeField]
        private readonly Color32 blackSquaresColor = new Color32(143, 100, 70, 255);

        private readonly Vector3 space = new Vector2(0.12f, 0.12f);

        private Board board = new Board();
        private void Start()
        {
            CreateGrid(board);
        }

        public Image[,] CreateGrid(Board board)
        {
            int fileSize = board.FileSize.ToInt();
            int rankSize = board.RankSize.ToInt();

            Image[,] squares = new Image[fileSize, rankSize];

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
            return squares;
        }

        private Image CreateSquaresImage(int file, int rank, int checkerCount)
        {
            Image squareTemp = Instantiate(square, this.transform);
            squareTemp.transform.position = new Vector3(file + space.x, rank + space.y, 0);

            if (checkerCount % 2 == 0)
            {
                squareTemp.color = blackSquaresColor;
                return squareTemp;
            }

            squareTemp.color = whiteSquaresColor;
            return squareTemp;
        }
    }

}
