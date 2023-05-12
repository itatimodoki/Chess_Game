using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using Chess_Game.Players;

namespace Chess_Game.Chessset.Pieces
{
    public class PieceArranger
    {
        private Dictionary<BoardPosition, PieceType> topSidePositions = new Dictionary<BoardPosition, PieceType>
        {
            [new BoardPosition(new File(8), new Rank(1))] = PieceType.Luke,
            [new BoardPosition(new File(8), new Rank(2))] = PieceType.Knight,
            [new BoardPosition(new File(8), new Rank(3))] = PieceType.Bishop,
            [new BoardPosition(new File(8), new Rank(4))] = PieceType.Queen,
            [new BoardPosition(new File(8), new Rank(5))] = PieceType.King,
            [new BoardPosition(new File(8), new Rank(6))] = PieceType.Bishop,
            [new BoardPosition(new File(8), new Rank(7))] = PieceType.Knight,
            [new BoardPosition(new File(8), new Rank(8))] = PieceType.Luke,

            [new BoardPosition(new File(7), new Rank(1))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(2))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(3))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(4))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(5))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(6))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(7))] = PieceType.Pawn,
            [new BoardPosition(new File(7), new Rank(8))] = PieceType.Pawn,
        };

        private Dictionary<BoardPosition, PieceType> underSidePositons= new Dictionary<BoardPosition, PieceType>
        {
            [new BoardPosition(new File(1), new Rank(1))] = PieceType.Luke,
            [new BoardPosition(new File(1), new Rank(2))] = PieceType.Knight,
            [new BoardPosition(new File(1), new Rank(3))] = PieceType.Bishop,
            [new BoardPosition(new File(1), new Rank(4))] = PieceType.Queen,
            [new BoardPosition(new File(1), new Rank(5))] = PieceType.King,
            [new BoardPosition(new File(1), new Rank(6))] = PieceType.Bishop,
            [new BoardPosition(new File(1), new Rank(7))] = PieceType.Knight,
            [new BoardPosition(new File(1), new Rank(8))] = PieceType.Luke,

            [new BoardPosition(new File(2), new Rank(1))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(2))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(3))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(4))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(5))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(6))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(7))] = PieceType.Pawn,
            [new BoardPosition(new File(2), new Rank(8))] = PieceType.Pawn,
        };

        public Board BoardInPiece(Board board,List<Piece> pieceList,Side side)
        {
            Dictionary<BoardPosition, PieceType> piecePositons = GetSidePositions(side);

            foreach(KeyValuePair<BoardPosition, PieceType> kvp in piecePositons)
            {
                Piece piece = GetPiece(pieceList, kvp.Value);
                board.SetPiece(piece, kvp.Key);
            }

            return board;
        }

        private Piece GetPiece(List<Piece> pieceList,PieceType pieceType)
        {
            foreach(Piece piece in pieceList)
            {
                if (piece.PieceType != pieceType)
                    continue;

                return piece;
            }
            throw new System.ArgumentException();
        }

        private Dictionary<BoardPosition, PieceType> GetSidePositions(Side side)
        {
            if(side == Side.Top)
            {
                return topSidePositions;
            }

            if(side == Side.Under)
            {
                return underSidePositons;
            }
            throw new System.Exception();
        }
    }
}
