using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');            
            p1.Draw();

            Point p2 = new Point(4, 5, '#');            
            p2.Draw();

            List<char> chars = new List<char>();
            chars.Add('*');
            chars.Add('#');
            chars.Add('+');
            chars.Add('=');

            Point p3 = new Point(7, 6, chars[2]);
            p3.Draw();

            Point p4 = new Point(8, 9, chars[^1]);
            p3.Draw();

            List<Point> points = new List<Point>
            {
                p1,
                p2,
                p3,
                p4
            };

            Console.ReadLine();
        }
       
    }
}
