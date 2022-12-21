using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Class
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public int CurrentFuel;
        public int FuelFor1km;
        public int Millage;
 
        public void Drive (int km)
        {
            if (CurrentFuel >= FuelFor1km*km)
            {
                Millage += km;
                CurrentFuel -= km *FuelFor1km;
            }
            else 
            {
                Console.WriteLine("Xeta");
            }
        }
  
    }
}
