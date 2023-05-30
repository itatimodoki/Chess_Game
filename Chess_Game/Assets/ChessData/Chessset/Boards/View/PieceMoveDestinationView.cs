using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.MoveLogics;

namespace Chess_Game.Chessset.Boards.View
{
    public class PieceMoveDestinationView
    {
        BoardView boardView;
        List<BoardPosition> moveDestination = new List<BoardPosition>();

        public PieceMoveDestinationView(BoardView boardView)
        {
            this.boardView = boardView;
        }

        public void View(PieceMoveDestination destinationList)
        {
            foreach (BoardPosition boardPosition in destinationList)
            {
                boardView.SquareChangeColor(boardPosition, SquareColorType.Destination);
                moveDestination.Add(boardPosition);
            }
        }

        public void Reset()
        {
            foreach (BoardPosition boardPosition in moveDestination)
            {
                boardView.SquareColorReset(boardPosition);
            }
            moveDestination.Clear();
        }
    }
}
