using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chess.Shapes
{
    internal class Bishop
    {
        private int X { get; set; } // Координата X текущего положения слона
        private int Y { get; set; } // Координата Y текущего положения слона

        public Bishop(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения для слона - только по диагонали
            int diffX = Math.Abs(newX - X);
            int diffY = Math.Abs(newY - Y);

            if (diffX == diffY)
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Слон сдвинулся на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для слона.");
            }
        }
    }
}

