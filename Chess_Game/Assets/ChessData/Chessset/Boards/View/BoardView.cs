using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chess_Game.Chessset.Boards.View
{
    public class BoardView : MonoBehaviour, IBoardObserver
    {


        [SerializeField]
        Image backImage = null;

        private Board board = new Board();

        private void Start()
        {

        }
        public void Initialize()
        {


        }

        public void Notify(Square updateSquare)
        {
            
        }


    }

}
