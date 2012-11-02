using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class Network
    {
        private readonly IList<Place> _places;
        private readonly Sequence _sequence = new Sequence();

        public Network()
        {
            _places = new List<Place>();
        }

        public void Execute()
        {
            foreach (Place place in _places)
            {
                _sequence.Increment();
                place.Execute(_sequence);
            }
        }
    }
}
