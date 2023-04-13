using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


namespace Chess_Game.Chessset.Boards
{
    public class BoardSize
    {
        public readonly int fileSize;
        public readonly int rankSize;

        private readonly float squaresSpace = 0.1f;

        public readonly Vector2 squareSize;
        public readonly Vector2[,] squaresPositions;

        public BoardSize(SpriteRenderer board, int fileSize, int rankSize)
        {
            if (fileSize <= 0 || rankSize <= 0)
                throw new ArgumentOutOfRangeException("BoardSize", "fileSize,rankSize ƒGƒ‰[");


            this.fileSize = fileSize;
            this.rankSize = rankSize;

            float sumSquareHeightSpace = squaresSpace * (fileSize + 1);
            float sumSquareWidthSpace = squaresSpace * (rankSize + 1);

            float difWidthSpace = board.bounds.size.x - sumSquareWidthSpace;
            float difHeightSize = board.bounds.size.y - sumSquareHeightSpace;

            squareSize = new Vector2(difWidthSpace / fileSize, difHeightSize / rankSize);

            squaresPositions = CreateSquarePosition();
        }

        private Vector2[,] CreateSquarePosition()
        {
            Vector2[,] positions = new Vector2[fileSize + 1, rankSize + 1];

            var squarePosition = new Vector2(squaresSpace + squareSize.x/2, squaresSpace + squareSize.y/2);

            for (int file = 1; file <= fileSize; file++)
            {
                float x = squaresSpace + squareSize.x;
                float y = squaresSpace + squareSize.y;
                for (int rank = 1; rank <= rankSize; rank++)
                {
                    positions[file, rank] = squarePosition;
                    squarePosition.x += x; ;

                }
                squarePosition.x = squaresSpace + squareSize.x / 2;
                squarePosition.y += y; ;
            }

            return positions;
        }

    }

}
