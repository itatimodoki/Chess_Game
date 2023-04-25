using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using Chess_Game.Players;
using System;

namespace Chess_Game.Chessset.Pieces
{
    public class PieceGenerator
    {
        readonly string blackLabel = "black";
        readonly string whiteLabel = "white";

        public IEnumerator LoadBlackPieceList(UnityAction<PieceList> callbak)
        {
            yield return PieceLoadLabel(blackLabel,result => callbak(result));
        }

        public IEnumerator LoadWhitePieceList(UnityAction<PieceList> callbak)
        {
            yield return PieceLoadLabel(whiteLabel, result => callbak(result));
        }

        /// <summary>
        /// ìØÇ∂LabelÇÃãÓÇÉçÅ[Éh
        /// </summary>
        /// <returns></returns>
        private IEnumerator PieceLoadLabel(string label,UnityAction<PieceList> callbak)
        {
            AsyncOperationHandle<IList<GameObject>> loadAssets;

            yield return loadAssets = Addressables.
                LoadAssetsAsync<GameObject>(label, null);

            if (loadAssets.Status != AsyncOperationStatus.Succeeded)
            {
                throw new System.Exception("Loadé∏îs");
            }

            PieceList pieceList = new PieceList();

            foreach (var piece in loadAssets.Result)
            {
                pieceList = pieceList.
                    AddRange(CreatePeice(piece.GetComponent<Piece>()));
            }

            callbak(pieceList);
        }

        private Piece[] CreatePeice(Piece piece)
        {
            Piece[] pieces = new Piece[(int)piece.TypeQuantity];
            for (int i = 0; i < (int)piece.TypeQuantity; i++)
            {
                pieces[i] = GameObject.Instantiate(piece);
                pieces[i].transform.position = Vector3.zero;
            }
            return pieces;
        }
    }

}
