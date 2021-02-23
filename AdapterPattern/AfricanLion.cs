using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class AfricanLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("I am a african lion");
        }
    }
}
