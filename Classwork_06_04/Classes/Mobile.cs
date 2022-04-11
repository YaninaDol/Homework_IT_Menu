using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Mobile:IPlatform
    {
        public string Hystory = "Платформа мобильных игр - это игровая программа для мобильных устройств, например сотовых телефонов, смартфонов, коммуникаторов, КПК и прочих (за исключением ноутбуков)";
        public void Info()
        {
            System.Console.WriteLine(" Мобильные ");
            System.Console.WriteLine(Hystory);
        }
    }
}
