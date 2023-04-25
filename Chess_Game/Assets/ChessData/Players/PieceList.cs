using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Players
{
    public class PieceList
    {
        public readonly List<Piece> pieceList;

        public PieceList()
        {
            pieceList = new List<Piece>();
        }

        private PieceList(List<Piece> pieceList)
        {
            this.pieceList = pieceList;
        }

        private void AddCheck(Piece addPiece)
        {
            if (pieceList.Find(piece => piece == addPiece))
            {
                throw new System.
                    ArgumentException("ä˘Ç…ë∂ç›ÇµÇƒÇ¢Ç‹Ç∑");
            }
        }

        public PieceList Add(Piece addPiece)
        {
            AddCheck(addPiece);

            var nextPieceList = new List<Piece>(pieceList);
            nextPieceList.Add(addPiece);
            return new PieceList(nextPieceList);
        }

        public PieceList AddRange(Piece[] pieceArray)
        {
            foreach(var pice in pieceArray)
            {
                AddCheck(pice);
            }

            var nextPieceList = new List<Piece>(pieceList);
            nextPieceList.AddRange(pieceArray);
            return new PieceList(nextPieceList);
        }

        public PieceList Remove(Piece removePiece)
        {
            var nextPieceList = new List<Piece>(pieceList);
            try
            {
                nextPieceList.Remove(removePiece);
            }
            catch(System.Exception exception)
            {
                Debug.LogError(exception);
                throw;
            }
            return new PieceList(nextPieceList);
        }

        public int Count()
        {
            return pieceList.Count;
        }
    }

}
