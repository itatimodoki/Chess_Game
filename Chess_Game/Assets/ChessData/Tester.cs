using System.Collections;
using System.Collections.Generic;
using Chess_Game.Players;
using System;
using UnityEngine.Events;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Pieces.View;
using Chess_Game.Chessset.Boards;
using UnityEngine;


public class Tester : MonoBehaviour
{

    [SerializeField]
    PieceView piece = null;



    void Start()
    {
        piece.InstancePiece(PieceType.Pawn, ColorType.Black);
        piece.transform.position = Vector3.zero;
    }



    private void SquareTest()
    {
        MovePositionList positionList = new MovePositionList();
        MovePosition movePosition = new MovePosition(new File(1), new Rank(1), false);
        positionList = positionList.Add(movePosition);
        Piece piece = new Piece(PieceType.Pawn, ColorType.Black, positionList);

        Square square = new Square(piece);
    }

    private void GridTest()
    {
        //MovePositionList positionList = new MovePositionList();
        //MovePosition movePosition = new MovePosition(new File(1), new Rank(1), false);
        //positionList = positionList.Add(movePosition);
        //Piece piece = new Piece(PieceType.Pawn, ColorType.Black, positionList);


        //Grid grid = new Grid(new File(8),new Rank(8));
        //grid.SetPiece(piece, new BoardPosition(new File(2), new Rank(3)));

    }


}
