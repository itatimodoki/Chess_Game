using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class Board : MonoBehaviour
    {
        [SerializeField]
        private Square square = null;

        [SerializeField]
        private SpriteRenderer boardSprite = null;

        [SerializeField]
        private Transform SquresParent = null;

        private readonly int maxFile = 8;
        private readonly int maxRank = 8;

        private Square[,] squares;


        private void Start()
        {
            BoardSize boardSize = new BoardSize(boardSprite, maxFile, maxRank);
            BoardGenerator boardGenerator = new BoardGenerator(square, boardSize);
            squares = boardGenerator.Create(SquresParent);
        }

        private void InitializeBoard()
        {

        }

        public Board PiecesMove()
        {
            //‹î‚ğ“®‚©‚·ˆ—
            return new Board();
        }

        public Board RemovePieces()
        {
            //ƒs[ƒX‚ğæ‚èœ‚­ˆ—
            return new Board();
        }
    }
}
