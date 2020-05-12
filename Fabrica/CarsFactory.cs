using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrica
{
    public interface CarsFactory
    {
        public int createSedan();
        public int createCoupe();
    }
}
