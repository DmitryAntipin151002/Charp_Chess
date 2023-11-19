using System;

namespace Chess.Shapes
{
    internal class Pawn
    {
        private int X { get; set; } // Координата X текущего положения пешки
        private int Y { get; set; } // Координата Y текущего положения пешки

        public Pawn(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения пешки
            if (newX == X && newY == Y + 1)
            {
                // Пешка двигается на одну клетку вперёд
                X = newX;
                Y = newY;
                Console.WriteLine($"Пешка сдвинулась на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для пешки.");
                // Здесь можно добавить другие правила движения пешки (например, первый ход на две клетки, атака по диагонали и т.д.)
            }
        }
    }
}
