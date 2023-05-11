using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
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
        Image myImage = null;

        public SquareView InstantiateSquareView(Vector3 position, Transform parent)
        {
            SquareView square = Instantiate(this, parent);
            square.transform.position = position;
            return square;
        }

        public void ChangeColor(ColorType colorType)
        {
            if (colorType == ColorType.Black)
            {
                myImage.color = blackSquaresColor;
                return;
            }

            if (colorType == ColorType.White)
            {
                myImage.color = whiteSquaresColor;
                return;
            }
        }
    }
}
