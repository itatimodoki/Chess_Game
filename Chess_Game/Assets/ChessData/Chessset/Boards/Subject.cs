using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;

namespace Chess_Game.Chessset.Boards
{
    public abstract class Subject
    {
        public List<IBoardObserver> observerList = new List<IBoardObserver>();

        public void AddObserver(IBoardObserver observer) 
        {
            observerList.Add(observer);
        }

        public void SetPieceNotifyObservers(Piece piece,BoardPosition boardPosition)
        {
            foreach(IBoardObserver observer in observerList)
            {
                observer.SetPieceNotify(piece,boardPosition);
            }
        }

        public void RemovePieceNotifyObservers(BoardPosition boardPosition)
        {
            foreach (IBoardObserver observer in observerList)
            {
                observer.RemovePieceNotify(boardPosition);
            }
        }
    }
}
