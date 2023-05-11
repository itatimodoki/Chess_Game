using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards.View
{
    public class GridView : MonoBehaviour
    {
        [SerializeField]
        SquareView squarePrefab = null;

        private readonly Vector3 space = new Vector2(0.12f, 0.12f);

        public SquareView[,] CreateGrid(Board board)
        {
            int fileSize = board.FileSize.ToInt();
            int rankSize = board.RankSize.ToInt();

            SquareView[,] squares = new SquareView[fileSize, rankSize];

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
            return squares;
        }

        private SquareView CreateSquaresImage(int file, int rank, int checkerCount)
        {
            Vector3 nextPosition = new Vector3(file + space.x, rank + space.y, 0);

            SquareView square = squarePrefab.InstantiateSquareView(nextPosition,this.transform);

            ColorType colorType = (ColorType)(checkerCount % 2) + 1;
            square.ChangeColor(colorType);
           
            return square;
        }

    }

}
