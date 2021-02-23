using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
	class AddFunctionAdapter : ILion
	{
        private ILion aLion;
        public AddFunctionAdapter(ILion aLion)
        {
            this.aLion = aLion;
        }
        public void Roar()
        {
            Eat();
            aLion.Roar();
        }

        public void Eat()
		{
            Console.WriteLine("I am eating");
        }
    }
}
