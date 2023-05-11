using System.Collections;
using System.Collections.Generic;
using Chess_Game.Players;
using System;
using UnityEngine.Events;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Pieces.View;
using Chess_Game.Chessset.Boards;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;


public class Tester : MonoBehaviour
{

    [SerializeField]
    PieceView piece = null;

    Board board = new Board();

    void Start()
    {
        Test();
    }

    private void Test()
    {
        PieceGenerator pieceGenerator = new PieceGenerator();

        List<Piece> pieces = pieceGenerator.Create(ColorType.Black);

        PieceArranger pieceArranger = new PieceArranger();

        pieceArranger.BoardInPiece(board, pieces, Side.Top);
    }



    

}
