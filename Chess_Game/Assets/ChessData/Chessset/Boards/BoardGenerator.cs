using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chess_Game.Chessset.Boards
{
    public class BoardGenerator
    {
        private readonly BoardSize boardSize;
        private readonly Square square;

        public BoardGenerator(Square square, BoardSize boardSize)
        {
            this.boardSize = boardSize;
            this.square = square;
        }

        public Square[,] Create(Transform parent)
        {
            Square[,] squares = new Square[boardSize.fileSize + 1, boardSize.rankSize + 1];

            int squareCount = 0;
            for (int file = 1; file <= boardSize.fileSize; file++)
            {
                for (int rank = 1; rank <= boardSize.rankSize; rank++)
                {
                    //Žs¼–Í—l‚É‚·‚é‚½‚ß‚É•ª‚¯‚é
                    if (squareCount % 2 == 0)
                    {
                        squares[file, rank] = SquareCreate(file, rank);
                        squares[file, rank].ToBlackColor();
                        squares[file, rank].transform.SetParent(parent);
                        squareCount++;
                        continue;
                    }
                    squares[file, rank] = SquareCreate(file, rank);
                    squares[file, rank].ToWhiteColor();
                    squares[file, rank].transform.SetParent(parent);
                    squareCount++;
                }
                //ŒðŒÝ‚É‚·‚é‚½‚ß‚É‚¸‚ç‚·
                squareCount++;
            }

            return squares;
        }

        private Square SquareCreate(int file, int rank)
        {
            square.transform.localScale = boardSize.squareSize;
            square.transform.position = boardSize.squaresPositions[file,rank];
            return GameObject.Instantiate(square);
        }

    }

}
