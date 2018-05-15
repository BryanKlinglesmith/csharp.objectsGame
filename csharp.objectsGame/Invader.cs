using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.objectsGame
{
    class Invader
    {
        private int _pathStep = 0;
        public MapLocation Location { get; private set; }

        public Invader(Path path)
        {
            Location = path.GetLocationAt(0);
        }
    }
}
