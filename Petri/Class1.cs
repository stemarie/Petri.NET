using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class Place : Base
    {
        public List<Token> Tokens { get; private set; }

        public Place()
        {
            Tokens = new List<Token>();
        }
    }

    public class Transition : Base
    { }

    public class Token
    {
        public Place Place { get; private set; }
    }

    public class Arc
    {
        public Base Source { get; private set; }
        public Base Destination { get; private set; }
        public int Capacity { get; private set; }
    }

    public class Base
    {
        public List<Arc> Arcs { get; private set; }
    }
}
