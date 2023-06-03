using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;
using System;
using Chess_Game.Chessset.Pieces.Model;

namespace Chess_Game.Chessset.Pieces
{
    public class PieceGenerator
    {
        public List<IPiece> CreatesAllPiece(ColorType colorType)
        {
            var pieces = new List<IPiece>();

            for(int i = 0;i < Enum.GetNames(typeof(PieceType)).Length; i++)
            {
                if ((PieceType)i == PieceType.Empty)
                    continue;

                IPiece piece = CreatePiece((PieceType)i, colorType);
                pieces.Add(piece);
            }

            return pieces;
        }

        public IPiece CreatePiece(PieceType pieceType, ColorType colorType)
        {
            switch (pieceType)
            {
                case PieceType.Pawn:
                    return new Pawn(pieceType,colorType);

                case PieceType.Luke:
                    return new Luke(pieceType, colorType);

                case PieceType.Knight:
                    return new Knight(pieceType, colorType);

                case PieceType.Bishop:
                    return new Bishop(pieceType, colorType);

                case PieceType.Queen:
                    return new Queen(pieceType, colorType);

                case PieceType.King:
                    return new King(pieceType, colorType);
            }
            return Piece.Empty;
        }

    }

}
