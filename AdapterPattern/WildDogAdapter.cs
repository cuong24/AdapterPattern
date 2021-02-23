using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class WildDogAdapter : ILion
    {
        private IDog mDog;
        public WildDogAdapter(IDog dog)
        {
            this.mDog = dog;
        }
        public void Roar()
        {
            Console.WriteLine("Shoot the wrong animal");
            mDog.Bark();
        }
    }
}
