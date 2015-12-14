﻿using System;
using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls (int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            HorizontalLine topLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
            HorizontalLine bottomLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

            wallList.Add(topLine);
            wallList.Add(bottomLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public bool IsHit(Figure figure)
        {
            foreach(var wall in wallList)
            {
                if(wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
        
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}