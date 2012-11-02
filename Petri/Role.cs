using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Petri
{
    public class Role : INameable
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public int Capacity
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
