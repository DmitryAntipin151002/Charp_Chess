using System;

namespace Chess
{
    internal class The_ChessBoard
    {
        private int[,] board; // Матрица, представляющая шахматную доску
        private const int BoardSize = 8; // Размер шахматной доски (8x8)

        public The_ChessBoard()
        {
            board = new int[BoardSize, BoardSize]; // Инициализация шахматной доски
        }

        public void PlacePiece(int x, int y, int pieceCode)
        {
            // Размещение фигуры на шахматной доске по координатам x и y
            if (x >= 0 && x < BoardSize && y >= 0 && y < BoardSize)
            {
                board[x, y] = pieceCode; // Код фигуры сохраняется на доске
            }
            else
            {
                Console.WriteLine("Недопустимые координаты для размещения фигуры.");
            }
        }

        public bool IsMoveValid(int startX, int startY, int targetX, int targetY)
        {
            // Проверка допустимости хода для выбранной фигуры
            if (startX >= 0 && startX < BoardSize && startY >= 0 && startY < BoardSize &&
                targetX >= 0 && targetX < BoardSize && targetY >= 0 && targetY < BoardSize)
            {
                // Проверка наличия фигуры на стартовой позиции
                if (board[startX, startY] != 0)
                {
                    // Допустимость хода определяется вашими правилами для каждой фигуры
                    // Здесь можно добавить логику проверки хода для конкретной фигуры
                    // Например, для пешки, ладьи, коня и т.д.
                    // Возвращаем true, если ход допустим, иначе false
                    return true; // Пример: всегда считаем ход допустимым для целей примера
                }
                else
                {
                    Console.WriteLine("На стартовой позиции нет фигуры.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Недопустимые координаты для хода.");
                return false;
            }
        }
    }
}
