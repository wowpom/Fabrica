using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica
{
    class Mercedes : CarsFactory
    {
        public int createSedan()
        {
            Console.WriteLine("Вы выбрали седан\n Ваша максимальная скорость : 120 км/ч");
            return 130;
        }

        public int createCoupe()
        {
            Console.WriteLine("Вы выбрали купе\n Ваша максимальная скорость : 100 км/ч");
            return 90;
        }
    }
}
