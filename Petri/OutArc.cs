using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class OutArc : IArc
    {
        public Place Destination { get; private set; }
        public string Name { get; private set; }
        public int Capacity { get; private set; }
        public int Weight { get; private set; }
        public bool Push()
        {
            return Destination.Receive();
        }
    }
}
