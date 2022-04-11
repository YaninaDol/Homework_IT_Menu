using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class PC:IPlatform
    {
        public string Hystory = " Платформа ПК  - это компьютерная игра, которая предназначена для работы на персональном компьютере (ПК), а не на каком-либо другом устройстве типа игровой консоли или аркадного автомата.";
        public void Info()
        {
            System.Console.WriteLine(" ПК ");
            System.Console.WriteLine(Hystory);

        }
    }
}
