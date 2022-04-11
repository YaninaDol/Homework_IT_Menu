using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class IOS:IPlatform
    {
      
        public Lenguage[] lenguages = new Lenguage[3];
        public string Hystory = " Платформа IOS - это мобильная операционная система для смартфонов, электронных планшетов, разрабатываемая и выпускаемая американской компанией Apple.";
        public IOS()
        {
            lenguages[0] = new Swift();
            lenguages[1] = new Dart();
            lenguages[2] = new React_Native();
        }

        public Lenguage this[int ind]
        {
            get { return lenguages[ind]; }
            // private set {  }
        }
        public void Info()
        {
            System.Console.WriteLine(" IOS ");
            System.Console.WriteLine(Hystory);
            System.Console.WriteLine("\n\n Языки разработки: ");
            for (int i = 0; i < 3; i++)
            {
                lenguages[i].Myinfo();
            }
            System.Console.WriteLine("0 - Возврат\n1 - Завершение");
            int n = int.Parse(System.Console.ReadLine());
            if (n == 0)
            {
                Mobilnie one = new Mobilnie();
                one.Print();
            }
            else
            {
                System.Console.WriteLine(" До встречи! ");
            }
        }

    }
}
