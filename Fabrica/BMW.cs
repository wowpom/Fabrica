using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica
{
    class BMW : CarsFactory 
    {
        public int createSedan()
        {
            Console.WriteLine("Вы выбрали седан\n Ваша максимальная скорость : 120 км/ч");
            return 120;
        }

        public int createCoupe()
        {
            Console.WriteLine("Вы выбрали купе\n Ваша максимальная скорость : 100 км/ч");
            return 100;
        }
    }
}
