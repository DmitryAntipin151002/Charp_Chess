using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chess.Shapes
{
    internal class Rook
    {
        private int X { get; set; } // Координата X текущего положения ладьи
        private int Y { get; set; } // Координата Y текущего положения ладьи

        public Rook(int initialX, int initialY)
        {
            X = initialX;
            Y = initialY;
        }

        public void MoveTo(int newX, int newY)
        {
            // Правила движения для ладьи - только по горизонтали или вертикали
            if ((newX == X && newY != Y) || (newX != X && newY == Y))
            {
                X = newX;
                Y = newY;
                Console.WriteLine($"Ладья сдвинулась на клетку ({X}, {Y}).");
            }
            else
            {
                Console.WriteLine("Это недопустимый ход для ладьи.");
            }
        }
    }
}

