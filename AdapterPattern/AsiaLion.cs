using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class AsiaLion : ILion
    {
        public void Roar()
        {
            Console.WriteLine("I am a asia lion");
        }
    }
}
