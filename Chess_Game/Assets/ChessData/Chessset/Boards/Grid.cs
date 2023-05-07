using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public class Grid
    {
        private readonly Square[,] squares;
        public Grid(File fileSize,Rank rankSize)
        {
            squares = Create(fileSize,rankSize);
        }

        private Grid(Square[,] squares)
        {
            this.squares = squares;
        }

        private Square[,] Create(File fileSize,Rank rankSize)
        {
            //“Y‚¦Žš‚Í1‚©‚ç
            Square[,] squares = new Square[fileSize.ToInt()+1, rankSize.ToInt()+1];

            for(int file = File.Min;file <= fileSize.ToInt();file++)
            {
                for(int rank = Rank.Min;rank <= rankSize.ToInt(); rank++)
                {
                    squares[file, rank] = new Square();
                }
            }
            return  squares;
        }

        public Grid SetPiece(Piece piece,BoardPosition position)
        {
            Square[,] nextSquare = squares;

            int file = position.FileToInt();
            int rank = position.RankToInt();

            nextSquare[file, rank] = new Square(piece);
            return new Grid(nextSquare);
        }

        public Piece GetPiece(BoardPosition position)
        {
            int file = position.FileToInt();
            int rank = position.RankToInt();

            return squares[file, rank].GetPiece();
        }
        public Square GetSquare(BoardPosition position)
        {
            int file = position.FileToInt();
            int rank = position.RankToInt();

            return squares[file, rank];
        }

        public Grid Remove(BoardPosition position)
        {
            Square[,] nextSquare = squares;

            int file = position.FileToInt();
            int rank = position.RankToInt();

            nextSquare[file, rank] = new Square();
            return new Grid(nextSquare);
        }



    }

}
