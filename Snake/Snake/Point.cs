﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int offset, Direction direction)
        {
           if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }

           if(direction == Direction.LEFT)
            {
                x = x - offset;
            }

           if(direction == Direction.DOWN)
            {
                y = y + offset;
            }

           if(direction == Direction.UP)
            {
                y = y - offset;
            }
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool IsHit(Point food)
        {
            return (food.x == this.x && food.y == this.y);
        }
    }
}
