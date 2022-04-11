using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
   abstract class Lenguage
    {
        protected string Language { get; set; }

        

        public Lenguage(string language)
        {
            Language = language;
        }

        public abstract void Myinfo();
    }
}
