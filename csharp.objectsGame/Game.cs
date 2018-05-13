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
                MapLocation mapLocation = new MapLocation(20, 20, map);
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (CsharpObjectsGameException)
            {
                Console.WriteLine("Unhandled CsharpObjectsGameException");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }


            //Tower tower = new Tower(); //the first Tower is the class that is called. Second tower is a variable with a class of "Tower". after the = is what the variable becomes.
        }
    }
}
