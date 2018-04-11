using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.objectsGame
{
    class Game
    {
        public void Main()
        {
            Map map = new Map();

            map.Width = 8;
            map.Height = 5;

            int area = map.Width * map.Height;

            //Tower tower = new Tower(); //the first Tower is the class that is called. Second tower is a variable with a class of "Tower". after the = is what the variable becomes.
        }
    }
}
