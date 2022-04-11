using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Menu
    {
       public Direction[] directions = new Direction[4];

        public Menu() 
        {
            directions[0] = new Game();
            directions[1] = new Mobilnie();
            directions[2] = new Desctop();
            directions[3] = new Web();
            
        }

        public Direction this[int ind]
        {
            get { return directions[ind]; }
            // private set {  }
        }
        public void Menu_chose()
        {
            System.Console.WriteLine(" Меню вкладки :\n 0 - Игры\n 1 - Мобильные\n 2 - Десктоп\n 3 - Сайты\n 4 - Выход");
            System.Console.Write("Ваш выбор: ");
            int ch = int.Parse(System.Console.ReadLine());
            if (ch != 4)
            {
                this[ch].Print();
            }
            else
            {
                System.Console.WriteLine(" До встречи! ");
            }
           
        }
    }
}
