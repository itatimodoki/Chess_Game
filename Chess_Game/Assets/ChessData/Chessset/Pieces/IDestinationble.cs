using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;
using Chess_Game.Players;

namespace Chess_Game.Chessset.Pieces
{
    public interface IDestinationble
    {
        public List<BoardPosition> GetDestination(Board board, BoardPosition basePosition,Side playSide);
    }

}
