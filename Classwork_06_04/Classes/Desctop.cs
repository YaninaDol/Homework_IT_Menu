using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Desctop:Direction
    {
        public IPlatform[] platforms = new IPlatform[2];



        public Desctop() : base("\n Десктоп ")
        {
            platforms[0] = new MacOS();
            platforms[1] = new Windows();


        }

        public IPlatform this[int ind]
        {
            get { return platforms[ind]; }
            // private set {  }
        }




        public void Chose(int ind)
        {

            this[ind].Info();

        }
        public override void Print()
        {
            System.Console.WriteLine("Вкладка :" + this.Name);

            System.Console.WriteLine("\n\n Виды:\n Mac OS \t Windows \n\n Выберите раздел:\n 0 - Mac OS\n 1 - Windows \n 2 - Вернуться ");
            int ch = int.Parse(System.Console.ReadLine());
            if (ch != 2)
            {
                this.Chose(ch);
            }
            else
            {
                Menu menu = new Menu();
                menu.Menu_chose();
            }
        }
    }
}
