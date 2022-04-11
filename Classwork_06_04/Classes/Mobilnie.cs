using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork_06_04
{
    class Mobilnie:Direction
    {

        public IPlatform[] platforms = new IPlatform[2];
       


        public Mobilnie() : base("\n Мобильные ")
        {
            platforms[0] = new Android();
            platforms[1] = new IOS();
            
          
            
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

            System.Console.WriteLine("\n\n Виды:\n Android \t IOS \n\n Выберите раздел:\n 0 - Android\n 1 - IOS\n 2 - Вернуться ") ;
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
