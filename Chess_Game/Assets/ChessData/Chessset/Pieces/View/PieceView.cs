using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces;
using UnityEngine.UI;

namespace Chess_Game.Chessset.Pieces.View
{
    public class PieceView : MonoBehaviour
    {

        [SerializeField, Tooltip("Pawn,Luke,Knight,Bishop,Queen,KingÇÃèáÇ≈ìoò^")]
        private List<Sprite> whitePieceSpriteList = new List<Sprite>();

        [SerializeField, Tooltip("Pawn,Luke,Knight,Bishop,Queen,KingÇÃèáÇ≈ìoò^")]
        private List<Sprite> blackPieceSpriteList = new List<Sprite>();

        private Dictionary<int, Sprite> pieceSpriteTable = new Dictionary<int, Sprite>();

        [SerializeField]
        Image myImage = null;

        public PieceView InstancePiece(PieceType pieceType,ColorType colorType)
        {
            PieceView piece = Instantiate(this);
            piece.CreateSpriteTable(colorType);
            piece.SpriteChange(pieceType);
            return piece;
        }

        private void CreateSpriteTable(ColorType colorType)
        {
            if(colorType == ColorType.Black)
            {
                pieceSpriteTable = SpriteTable(blackPieceSpriteList);
            }

            if(colorType == ColorType.White)
            {
                pieceSpriteTable = SpriteTable(whitePieceSpriteList);
            }
        }

        private Dictionary<int, Sprite> SpriteTable(List<Sprite> sprites)
        {
            Dictionary<int, Sprite> table = new Dictionary<int, Sprite>();

            foreach(int typeNumber in Enum.GetValues(typeof(PieceType)))
            {
                table.Add(typeNumber, sprites[typeNumber]);
            }

            return table;
        }

        public void SpriteChange(PieceType type)
        {
            try
            {
                myImage.sprite = pieceSpriteTable[(int)type];
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
