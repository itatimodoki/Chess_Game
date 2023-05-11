using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chess_Game.Chessset.Boards.View
{
    public class BoardView : MonoBehaviour, IBoardObserver
    {

        [SerializeField]
        GridView gridView = null;

        Board Board = new Board();

        private void Start()
        {
            Initialize(Board);
        }
        public void Initialize(Board board)
        {

            gridView.CreateGrid(board);
        }

        public void Notify(Square updateSquare)
        {
            
        }


    }

}
