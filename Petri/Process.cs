using System.Collections.Generic;

namespace Petri
{
    public class Process : INameable
    {
        public Process()
        {
            Roles = new List<Role>();
        }

        public List<Role> Roles { get; private set; }

        public int Weight { get; set; }

        public int Time { get; set; }

        public string Name { get; private set; }

        public IEnumerable<InArc> Next { get; private set; }
    }
}