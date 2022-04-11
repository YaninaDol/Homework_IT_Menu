using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class _2D : Type
    {
      
        IPlatform[] platforms=new IPlatform[3];
       
       
        public _2D() :base("2D", "2D игры – игры с видом сверху, то есть камера  расположена прямо перпендикулярно или под углом над персонажем.")
        {
            platforms[0] = new Console();
            platforms[1] = new Mobile();
            platforms[2] = new PC();
        }
        public IPlatform this[int ind]
        {
            get { return platforms[ind]; }
            // private set {  }
        }
        public override void Information()
        {
            System.Console.WriteLine("\n\n Примечание: "+this.Hystory);
            System.Console.WriteLine("\n\n Платформы разработки : ");
            platforms[0].Info();
            platforms[1].Info();
            platforms[2].Info();

            System.Console.WriteLine("0 - Возврат\n1 - Завершение");
            int n = int.Parse(System.Console.ReadLine());
            if (n == 0)
            {
                Game one = new Game();
                one.Print();
            }
            else
            {
                System.Console.WriteLine(" До встречи! ");
            }
        }

    }
}
