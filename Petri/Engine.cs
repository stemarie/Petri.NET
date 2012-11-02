using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class Engine : IList<Network>
    {
        private readonly IList<Network> _networks;

        public Engine()
        {
            _networks = new List<Network>();
        }

        public void Execute()
        {
            foreach (Network network in _networks)
            {
                network.Execute();
            }
        }

        public IEnumerator<Network> GetEnumerator()
        {
            return _networks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Network item)
        {
            _networks.Add(item);
        }

        public void Clear()
        {
            _networks.Clear();
        }

        public bool Contains(Network item)
        {
            return _networks.Contains(item);
        }

        public void CopyTo(Network[] array, int arrayIndex)
        {
            _networks.CopyTo(array, arrayIndex);
        }

        public bool Remove(Network item)
        {
            return _networks.Remove(item);
        }

        public int Count { get { return _networks.Count; } }
        public bool IsReadOnly { get { return _networks.IsReadOnly; } }
        public int IndexOf(Network item)
        {
            return _networks.IndexOf(item);
        }

        public void Insert(int index, Network item)
        {
            _networks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _networks.RemoveAt(index);
        }

        public Network this[int index]
        {
            get { return _networks[index]; }
            set { _networks[index] = value; }
        }
    }
}
