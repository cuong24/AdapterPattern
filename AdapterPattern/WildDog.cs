using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    interface IDog
    {
        void Bark();
    }
    class WildDog : IDog
    {
        public void Bark()
        {
            Console.WriteLine("I am a wild dog");
        }
    }
}
