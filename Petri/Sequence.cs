using System;

namespace Petri
{
    public class Sequence : IEquatable<Sequence>
    {
        public long Current { get; private set; }
        public Sequence Parent { get; private set; }
        public static readonly Sequence EmptySequence = new Sequence();

        public Sequence()
        {
            Current = 0;
            Parent = null;
        }

        public void Increment()
        {
            if (Current == long.MaxValue)
            {
                if (Parent == null)
                {
                    Parent = new Sequence();
                }
                Parent.Increment();
                Current = 0;
            }
            else
                Current++;
        }

        public string GetSequence()
        {
            return Parent != null
                       ? string.Format("{0}.{1}", Parent.GetSequence(), Current.ToString())
                       : Current.ToString();
        }

        public bool Equals(Sequence other)
        {
            return Parent != null
                       ? Current.Equals(other.Current) && Parent.Equals(other.Parent)
                       : Current.Equals(other.Current);
        }
    }
}