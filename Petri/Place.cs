using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petri
{
    public class Place : INameable
    {
        public long Tokens { get; private set; }
        private Sequence _sequence;

        public Place()
        {
            Tokens = 0;
            _sequence = Sequence.EmptySequence;
        }

        public string Name { get; private set; }

        public IEnumerable<OutArc> Next { get; private set; }

        public void Execute(Sequence sequence)
        {
            if (_sequence != sequence)
            {
                ExecuteMe();
                _sequence = sequence;
            }
        }

        private void ExecuteMe()
        {
            foreach (OutArc arc in Next)
            {
                if (arc.Push())
                    Tokens--;
            }
        }

        public bool Receive()
        {
            if (Tokens < Maxtokens)
            {
                Tokens++;
                return true;
            }
            return false;
        }

        protected long Maxtokens { get; private set; }
    }
}
