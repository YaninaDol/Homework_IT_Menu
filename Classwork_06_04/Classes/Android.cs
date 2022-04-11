using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Android:IPlatform
    {
        
        public Lenguage[] lenguages = new Lenguage[4];
        public string Hystory = " Платформа Android - это операционная система, которая может управлять мобильным устройством (телефоном, планшетным компьютером, смартфоном).";
        public Android()
        {
            lenguages[0] = new Java();
            lenguages[1] = new Kotlin();
            lenguages[2] = new Dart();
            lenguages[3] = new React_Native();
        }

        public Lenguage this[int ind]
        {
            get { return lenguages[ind]; }
            // private set {  }
        }
        public void Info()
        {
            System.Console.WriteLine(" Android ");
            System.Console.WriteLine(Hystory);
            System.Console.WriteLine("\n\n Языки разработки: ");
            for (int i=0;i<4;i++)
            {
                lenguages[i].Myinfo();
            }

            System.Console.WriteLine("0 - Возврат\n1 - Завершение");
            int n = int.Parse(System.Console.ReadLine());
            if(n==0)
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
