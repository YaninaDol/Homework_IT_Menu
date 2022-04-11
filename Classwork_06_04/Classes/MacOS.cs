using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class MacOS:IPlatform
    {
        public Lenguage[] lenguages = new Lenguage[8];
        public string Hystory = " Платформа Mac OS (Macintosh Operating System) — семейство проприетарных операционных систем от компании Apple. Разработана для линейки персональных компьютеров Macintosh. Популяризация графического интерфейса пользователя в современных операционных системах часто считается заслугой Mac OS. Она была впервые представлена в 1984 году вместе с персональным компьютером Macintosh 128K.";
        public MacOS()
        {
            lenguages[0] = new Java();
            lenguages[1] = new Kotlin();
            lenguages[2] = new Dart();
            lenguages[3] = new React_Native();
            lenguages[4] = new Python();
            lenguages[5] = new NodeJS();
            lenguages[6] = new C_plus();
            lenguages[7] = new C_sharp();

        }

        public Lenguage this[int ind]
        {
            get { return lenguages[ind]; }
            // private set {  }
        }
        public void Info()
        {
            System.Console.WriteLine(" Mac OS ");
            System.Console.WriteLine(Hystory);
            System.Console.WriteLine("\n\n Языки разработки: ");
            for (int i = 0; i < 8; i++)
            {
                lenguages[i].Myinfo();
            }
            System.Console.WriteLine("0 - Возврат\n1 - Завершение");
            int n = int.Parse(System.Console.ReadLine());
            if (n == 0)
            {
                Desctop one = new Desctop();
                one.Print();
            }
            else
            {
                System.Console.WriteLine(" До встречи! ");
            }

        }

    }
}
