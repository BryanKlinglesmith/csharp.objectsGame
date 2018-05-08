﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.objectsGame
{
    class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceTo(int x, int y)
        {

            //the line below returns the distance between 2 cartesian points

            return (int)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));

            //The line above returns the exact same answer as the 5 lines below return

            // int xDiff = X - x;
            // int yDiff = Y - y;

            // int xDiffSquared = xDiff * xDiff;
            // int yDiffSquared = yDiff * yDiff;

            // return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
        }
    }
}
