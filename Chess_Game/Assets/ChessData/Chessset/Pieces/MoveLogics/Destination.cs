using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Chess_Game.Chessset.Pieces.Model;
using Chess_Game.Chessset.Boards;
using System.Linq;
using Chess_Game.Players;

namespace Chess_Game.Chessset.Pieces.MoveLogics
{
    public static class Destination
    {
        /// <summary>
        /// �s��̍��W�v�Z
        /// �ՊO��Empty��Ԃ�
        /// </summary>
        public static BoardPosition DestinationCalculation(BoardPosition basePosition, MoveRange moveRange,Side playSide)
        {
            MoveRange sideIncludeMoveRnage = moveRange;
            if (playSide == Side.Top)
                sideIncludeMoveRnage = sideIncludeMoveRnage.TurnOver();

            var file = new File(basePosition.FileToInt());
            file = file.SafetedAdd(sideIncludeMoveRnage.FileRange);

            var rank = new Rank(basePosition.RankToInt());
            rank = rank.SafetedAdd(sideIncludeMoveRnage.RankRange);

            if (file == File.Empty || rank == Rank.Empty)
                return BoardPosition.Empty;

            return new BoardPosition(file, rank);
        }

        /// <summary>
        /// �����̍s��̍��W�v�Z
        /// �ՊO��Empty��Ԃ�
        /// </summary>
        public static BoardPosition[] DestinationCalculations(BoardPosition basePosition,MoveRange[] moveRanges, Side playSide)
        {
            var boardPositions = new List<BoardPosition>();

            foreach(MoveRange moveRange in moveRanges)
            {
                BoardPosition movePosition = DestinationCalculation(basePosition, moveRange,playSide);
                if (movePosition.IsEmpty())
                    continue;
                
                boardPositions.Add(movePosition);
            }

            return boardPositions.ToArray();
        }

        /// <summary>
        /// ����̂��ׂĂ̍s��̍��W�v�Z
        /// </summary>
        public static BoardPosition[] LineDestinationCalculation(BoardPosition basePosition,MoveLineRange moveLineRange,Side playSide)
        {
            var boardPositions = new List<BoardPosition>();

            foreach(MoveRange moveRange in moveLineRange)
            {
                BoardPosition movePosition = DestinationCalculation(basePosition, moveRange, playSide);

                if (movePosition.IsEmpty())
                    break;

                boardPositions.Add(movePosition);
            }
            return boardPositions.ToArray();
        }

        /// <summary>
        /// �ՂƂ��ׂĂ̍s����W����A���ۂ̍s����W�̐���
        /// </summary>
        public static IList<BoardPosition> LineDestination(Board board, BoardPosition[] line,ColorType colorType)
        {
            var lineMovePositions = new List<BoardPosition>();
            foreach (BoardPosition boardPosition in line)
            {

                if (boardPosition.IsEmpty())
                    continue;

                IPiece piece = board.GetPiece(boardPosition);
                if (piece.GetPieceType() == PieceType.Empty)
                {
                    lineMovePositions.Add(boardPosition);
                    continue;
                }

                if (colorType == piece.GetColorType())
                    break;

                lineMovePositions.Add(boardPosition);
                break;
            }
            return lineMovePositions;
        }
    }

}
