using System.Collections.Generic;

namespace Petri
{
    public class Decision : INameable
    {
        public List<DecisionArc> Decisions { get; private set; }

        public Decision()
        {
            Decisions = new List<DecisionArc>();
        }

        public class DecisionArc
        {
            public IArc Arc { get; private set; }
            public float Odd { get; private set; }
        }

        public string Name { get; private set; }

        public IEnumerable<InArc> Next { get; private set; }
    }
}