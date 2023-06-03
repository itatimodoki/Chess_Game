using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using Chess_Game.Chessset.Pieces.View;
using UnityEngine.UI;

namespace Chess_Game.Chessset.Boards.View
{
    public class SquareView : MonoBehaviour
    {
        [SerializeField]
        private readonly Color32 whiteSquaresColor = new Color32(205, 161, 111, 255);
        [SerializeField]
        private readonly Color32 blackSquaresColor = new Color32(143, 100, 70, 255);
        [SerializeField]
        private readonly Color32 destinationColor = new Color32(0, 255, 255, 255);

        [SerializeField]
        Image myImage = null;

        private PieceView holdPiece;

        private SquareColorType startColor;

        private BoardPosition myBoardPosition = BoardPosition.Empty;

        public SquareView InstantiateSquareView(Vector3 position, BoardPosition boardPosition, Transform parent, SquareColorType startColor)
        {
            SquareView square = Instantiate(this, parent);
            square.transform.position = position;
            square.myBoardPosition = boardPosition;

            square.SetStartColor(startColor);
            square.ChangeColor(startColor);

            return square;
        }

        public BoardPosition GetBoardPosition()
        {
            return myBoardPosition;
        }

        public void SetPiece(PieceView piece)
        {
            holdPiece = piece;
            holdPiece.transform.SetParent(this.transform);
            holdPiece.transform.localScale = Vector3.one;
            holdPiece.transform.position = this.transform.position;
        }

        public void RemovePiece()
        {
            if (holdPiece == null)
                return;

            holdPiece.gameObject.SetActive(false);

        }

        public void ChangeColor(SquareColorType colorType)
        {
            if (colorType == SquareColorType.Black)
                myImage.color = blackSquaresColor;

            if (colorType == SquareColorType.White)
                myImage.color = whiteSquaresColor;

            if (colorType == SquareColorType.Destination)
                myImage.color = destinationColor;
        }

        public void ResetColor()
        {
            ChangeColor(startColor);
        }

        public void SetStartColor(SquareColorType colorType)
        {
            startColor = colorType;
        }

        public bool IsPieceHold()
        {
            return holdPiece != null;
        }
    }
}
