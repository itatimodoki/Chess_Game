using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Players;
using System;
using UnityEngine.Events;
using Chess_Game.Chessset.Pieces;


public class Tester : MonoBehaviour
{

    PieceList pieceList = new PieceList();
    [SerializeField]
    Piece piece1;

    [SerializeField]
    Piece piece2;

    [SerializeField]
    Piece piece3;

    [SerializeField]
    Piece piece4;

    Piece[] pieces;

    void Start()
    {

        pieces = new Piece[]
        {
            piece1,piece2,piece3,piece4,
        };

        for(int i= 0;i < 4; i++)
        {
            pieceList = pieceList.Add(pieces[0]);
        }
    }


}
