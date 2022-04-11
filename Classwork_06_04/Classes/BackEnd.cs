using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class BackEnd:IPlatform
    {
        public Lenguage[] lenguages = new Lenguage[6];
        public string Hystory = " Бэкенд (англ. back-end) — программно-аппаратная часть сервиса, отвечающая за функционирование его внутренней части.";
        public BackEnd()
        {
            lenguages[0] = new Java();
            lenguages[1] = new C_sharp();
            lenguages[2] = new NodeJS();
            lenguages[3] = new PHP();
            lenguages[4] = new Python();
            lenguages[5] = new Ruby();
        }

        public Lenguage this[int ind]
        {
            get { return lenguages[ind]; }
            // private set {  }
        }
        public void Info()
        {
            System.Console.WriteLine(" Бэкенд ");
            System.Console.WriteLine(Hystory);
            System.Console.WriteLine("\n\n Языки разработки: ");
            for (int i = 0; i < 6; i++)
            {
                lenguages[i].Myinfo();
            }

            System.Console.WriteLine("0 - Возврат\n1 - Завершение");
            int n = int.Parse(System.Console.ReadLine());
            if (n == 0)
            {
                Web one = new Web();
                one.Print();
            }
            else
            {
                System.Console.WriteLine(" До встречи! ");
            }


        }

    }
}
