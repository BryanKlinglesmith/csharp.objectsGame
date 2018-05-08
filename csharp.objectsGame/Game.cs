using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.objectsGame
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);

            Point point = new Point(4, 2);

            Console.WriteLine(point.DistanceTo(5, 5));

            //Tower tower = new Tower(); //the first Tower is the class that is called. Second tower is a variable with a class of "Tower". after the = is what the variable becomes.
        }
    }
}
