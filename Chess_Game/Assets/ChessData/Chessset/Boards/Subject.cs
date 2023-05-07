using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public abstract class Subject
    {
        public List<IBoardObserver> observerList = new List<IBoardObserver>();

        public void AddObserver(IBoardObserver observer) 
        {
            observerList.Add(observer);
        }

        public void Notify()
        {
            foreach(IBoardObserver observer in observerList)
            {
               // observer.Update()
            }
        }

    }
}
