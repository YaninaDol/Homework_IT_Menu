using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    public abstract class Type
    {

        public string Direction_Name { get; set; }
        public string Hystory { get; set; }

        public Type()
        {

        }
        protected Type(string direction_Name, string hystory)
        {
            Direction_Name = direction_Name;
            Hystory = hystory;
            
        }


        public abstract void Information();

      

    }
}
