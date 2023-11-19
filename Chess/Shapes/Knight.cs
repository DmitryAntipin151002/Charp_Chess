using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chess.Shapes
{
    internal class Knight
    {
        private int X { get; set; } // Координата X текущего положения коня
        private int Y { get; set; } // Координата Y текущего положения коня

        public Knight(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения для коня - "L"-образное движение
            int diffX = Math.Abs(newX - X);
            int diffY = Math.Abs(newY - Y);

            if ((diffX == 1 && diffY == 2) || (diffX == 2 && diffY == 1))
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Конь сдвинулся на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для коня.");
            }
        }
    }
}

