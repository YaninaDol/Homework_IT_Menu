using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class FrontEnd:IPlatform
    {
        public Lenguage[] lenguages = new Lenguage[5];
        public string Hystory = " Фронтенд (англ. front-end) — клиентская сторона пользовательского интерфейса к программно-аппаратной части сервиса.";
        public FrontEnd()
        {
            lenguages[0] = new Html_CSS();
            lenguages[1] = new React_Native();
            lenguages[2] = new Angular();
            lenguages[3] = new Vue();
            lenguages[4] = new Razor();
          
        }

        public Lenguage this[int ind]
        {
            get { return lenguages[ind]; }
            // private set {  }
        }
        public void Info()
        {
            System.Console.WriteLine(" Фронтенд ");
            System.Console.WriteLine(Hystory);
            System.Console.WriteLine("\n\n Языки разработки: ");
            for (int i = 0; i < 5; i++)
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
