using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Shapes
{
    internal class King
    {
        private int X { get; set; } // Координата X текущего положения короля
        private int Y { get; set; } // Координата Y текущего положения короля

        public King(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения для короля - на одну клетку в любом направлении
            int diffX = Math.Abs(newX - X);
            int diffY = Math.Abs(newY - Y);

            if ((diffX <= 1 && diffY == 0) || (diffX == 0 && diffY <= 1) || (diffX == diffY && diffX == 1))
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Король сдвинулся на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для короля.");
            }
        }
    }
}

