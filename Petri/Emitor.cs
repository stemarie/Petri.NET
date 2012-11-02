using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class Emitor : INameable
    {
        public string Name { get; private set; }

        public IEnumerable<InArc> Next { get; private set; }
    }
}
