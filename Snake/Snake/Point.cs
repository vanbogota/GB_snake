using System;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
                
        public Point(int _x, int _y, char _sym )
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    x -= offset;
                    break;
                case Direction.Right:
                    x += offset;
                    break;
                case Direction.Up:
                    y -= offset;
                    break;
                case Direction.Down:
                    y += offset;
                    break;
                default:
                    break;
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
