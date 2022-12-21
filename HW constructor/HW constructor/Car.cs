using System;
using System.Collections.Generic;
using System.Text;

namespace HW_constructor
{
    internal class Car
    {
        public int FuelCapacity; //емкость топлива
        public int CurrentFuel; //текущее топливо

        public void AddFuel(int fuel)
        {
            if (fuel <= (FuelCapacity - CurrentFuel))
            {
                CurrentFuel += fuel;
            }
            else
            {
                Console.WriteLine("Daxil edilen fuel capacitiden cox ola bilmez!");
            }
        }
    }
}
