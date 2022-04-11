using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    public abstract class Direction
    {
        public string Name { get; set; }
        public string  Hystory { get; set; }

        protected Direction(string name, string hystory)
        {
            Name = name;
            Hystory = hystory;
        }
        protected Direction(string name)
        {
            Name = name;
           
        }

        public abstract void Print();
    }
}
