using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chess.Shapes
{
    internal class Queen
    {
        private int X { get; set; } // Координата X текущего положения ферзя
        private int Y { get; set; } // Координата Y текущего положения ферзя

        public Queen(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения для ферзя - по горизонтали, вертикали и диагонали
            int diffX = Math.Abs(newX - X);
            int diffY = Math.Abs(newY - Y);

            if ((diffX == 0 && diffY != 0) || (diffX != 0 && diffY == 0) || (diffX == diffY))
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Ферзь сдвинулся на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для ферзя.");
            }
        }
    }
}
