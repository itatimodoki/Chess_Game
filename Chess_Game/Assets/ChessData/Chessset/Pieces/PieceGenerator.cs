using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;
using System;

namespace Chess_Game.Chessset.Pieces
{
    public class PieceGenerator
    {


        public List<Piece> Create(ColorType colorType)
        {
            List<Piece> pieces = new List<Piece>();

            for(int i = 0;i < Enum.GetNames(typeof(PieceType)).Length; i++)
            {
                if ((PieceType)i == PieceType.Empty)
                    continue;

                Piece piece = ByPieceTyoeCreate((PieceType)i, colorType);
                pieces.Add(piece);
            }

            return pieces;
        }

        private MovePositionList GetMovePositionList(PieceType type)
        {
            switch (type)
            {
                case PieceType.Pawn:
                    return new PawnMovePositionList();

                case PieceType.Luke:
                    return new LukeMovePositionList();

                case PieceType.Knight:
                    return new KingMovePositionList();

                case PieceType.Bishop:
                    return new BishopMovePositionList();

                case PieceType.Queen:
                    return new QueenMovePositionList();

                case PieceType.King:
                    return new KingMovePositionList();
            }
            return new EmptyMovePositonList();
        }

        private Piece ByPieceTyoeCreate(PieceType pieceType, ColorType colorType)
        {
            MovePositionList movePositionList = GetMovePositionList(pieceType);
            return new Piece(pieceType, colorType, movePositionList);

        }
    }

}
