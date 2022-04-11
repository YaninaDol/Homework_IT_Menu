using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Game : Direction
    {
       public Type[] types = new Type[2];
        public Lenguage[] lenguages = new Lenguage[2];


        public Game() : base("Game")
        {
            types[0] = new _2D();
            types[1] = new _3D();
            lenguages[0] = new C_plus();
            lenguages[1] = new C_sharp();
;
        }

        public Type this[int ind]
        {
            get { return types[ind]; }
            // private set {  }
        }

       


        public void Chose(int ind)
        {
           
            this[ind].Information();
           
        }
        public override void Print()
        {
            System.Console.WriteLine("Вкладка :"+ this.Name);
            System.Console.WriteLine(" Языки разработки: ");
            lenguages[0].Myinfo();
            lenguages[1].Myinfo();

            System.Console.WriteLine(" Виды:\n {0} \t {1} \n Выберите раздел:\n 0 - 2D\n 1 - 3D\n 2 - Вернуться ",types[0].Direction_Name, types[1].Direction_Name);
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
