using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.objectsGame
{
    class CsharpObjectsGameException : System.Exception
    {
        public CsharpObjectsGameException()
        {

        }

        public CsharpObjectsGameException(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : CsharpObjectsGameException
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
