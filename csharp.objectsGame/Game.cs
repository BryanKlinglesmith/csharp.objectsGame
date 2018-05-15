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

            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                     }
                 );
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CsharpObjectsGameException)
            {
                Console.WriteLine("Unhandled CsharpObjectsGameException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception" + ex);
            }


            //Tower tower = new Tower(); //the first Tower is the class that is called. Second tower is a variable with a class of "Tower". after the = is what the variable becomes.
        }
    }
}
