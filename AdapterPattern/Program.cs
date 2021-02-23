using System;

namespace AdapterPattern
{
    class Hunter
    {
        public void Hunt(ILion lion)
        {
            lion.Roar();
        }

        public void Hunt(IDog dog)
        {
            dog.Bark();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var hunter = new Hunter();

            var africanLion = new AfricanLion();
            hunter.Hunt(africanLion);

            var asiaLion = new AsiaLion();
            hunter.Hunt(asiaLion);

            var wildDog = new WildDog();
            var wildDogAdapter = new WildDogAdapter(wildDog);
            hunter.Hunt(wildDogAdapter);

			var addFunctionAdapter = new AddFunctionAdapter(asiaLion);
			hunter.Hunt(addFunctionAdapter);


			Console.ReadLine();
        }
    }
}