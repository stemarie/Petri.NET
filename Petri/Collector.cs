using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class Collector : INameable
    {
        public string Name { get; private set; }

        public IEnumerable<OutArc> Previous { get; private set; }
    }
}
