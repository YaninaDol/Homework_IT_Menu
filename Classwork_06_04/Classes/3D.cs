using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class _3D : Type
    {
        IPlatform[] platforms = new IPlatform[3];

        public _3D() : base("3D", "3D - это трехмерное пространство, где материалы и текстуры отрисовываются на поверхности игровых объектов, формируя целостное окружение, персонажей и объекты игрового мира. ")
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
            System.Console.WriteLine("\n\n Примечание : " + this.Hystory);
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
