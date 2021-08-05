﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine lineUp = new HorizontalLine(0, mapWidth-2, 0, '+');            
            HorizontalLine lineDown = new HorizontalLine(0, mapWidth-2, mapHeight-1, '+');
            VerticalLine lineLeft = new VerticalLine(0, mapHeight-1, 0, '+');            
            VerticalLine lineRight = new VerticalLine(0, mapHeight-1, mapWidth-2, '+');

            wallList.Add(lineUp);
            wallList.Add(lineDown);
            wallList.Add(lineLeft);
            wallList.Add(lineRight);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;                
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
