using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chess_Game.Chessset.Boards
{
    public class Square : MonoBehaviour
    {

        public readonly Color32 whiteSquaresColor = new Color32(205,161,111,255);

        public readonly Color32 blackSquaresColor = new Color32(143, 100, 70, 255);

        [SerializeField]
        private SpriteRenderer mySpriteRenderer = null;

        public void ToBlackColor()
        {
            ColorChange(blackSquaresColor);
        }

        public void ToWhiteColor()
        {
            ColorChange(whiteSquaresColor);
        }

        private void ColorChange(Color nextColor)
        {
            mySpriteRenderer.color = nextColor;
        }
    }

}
