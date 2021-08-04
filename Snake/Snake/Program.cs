using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
            
            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            lineUp.Draw();
            HorizontalLine lineDown = new HorizontalLine(0, 78, 24, '+');
            lineDown.Draw();

            VerticalLine lineLeft = new VerticalLine(0, 24, 0, '+');
            lineLeft.Draw();

            VerticalLine lineRight = new VerticalLine(0, 24, 78, '+');
            lineRight.Draw();

            //первая точка - начало змейки
            Point p = new Point(8, 9, '*');

            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ChangeDirection(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            
        }
       
    }
}
