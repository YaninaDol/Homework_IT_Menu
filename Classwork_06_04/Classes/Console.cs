using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Console:IPlatform
    {
        public string Hystory = "Платформа консоль — компьютерная игра, которая предназначена для работы на игровой консоли (игровой приставке), а не на каком-либо другом устройстве типа персонального компьютера или аркадного автомата.";
        public void Info()
        {
            System.Console.WriteLine(" Консоль ");
            System.Console.WriteLine(Hystory);
        }
    }
}
