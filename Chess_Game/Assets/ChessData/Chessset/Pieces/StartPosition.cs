using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Boards;

namespace Chess_Game.Chessset.Pieces
{
    public class StartPosition
    {
        private readonly File file;
        private readonly Rank rank;
        public StartPosition(File file,Rank rank)
        {
            this.file = file;
            this.rank = rank;
        }


    }

}
