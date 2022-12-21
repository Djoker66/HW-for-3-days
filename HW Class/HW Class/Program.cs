using System;
using System.Threading;

namespace HW_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Notebook ntb1 = new Notebook()
            {
                Name = "MacBookpro",
                Brand = "Apple",
                Price = 2900
            };

            Notebook ntb2 = new Notebook()
            {
                Name = "Lenovo",
                Brand = "GamePad",
                Price = 3900
            };
            Notebook ntb3 = new Notebook()
            {
                Name = "Rog strix",
                Brand = "Asus",
                Price = 2600
            };
            Notebook ntb4 = new Notebook()
            {
                Name = "HP",
                Brand = "345S",
                Price = 900
            };
            Notebook ntb5 = new Notebook()
            {
                Name = "Asus",
                Brand = "TUF",
                Price = 2900
            };

            Notebook[] notebooks = { ntb1, ntb2, ntb3, ntb4, ntb5 };

            Console.WriteLine("Min");
            string minPriceStr = Console.ReadLine();
            int minPrice = Convert.ToInt32(minPriceStr);

            Console.WriteLine("Max");
            string maxPriceStr = Console.ReadLine();
            int maxPrice = Convert.ToInt32(maxPriceStr);

            var filteredNotebooks = byPrice(minPrice, maxPrice, notebooks);

            if (filteredNotebooks.Length == 0)
            {
                Console.WriteLine("Axtardiginiz deyerde data yoxdur!");
            }
            else
            {
                for (int i = 0; i < filteredNotebooks.Length; i++)
                {
                    Console.WriteLine(filteredNotebooks[i].GetInfo());
                }

            }


            Car car1 = new Car
            {
                Brand = "Lexus",
                Model = "Lx570",
                CurrentFuel = 60,
                FuelFor1km = 3,
                Millage = 4235,
            };

            Console.WriteLine("Getmek istediyiniz mesafeni daxil edin");
            string kmStr = Console.ReadLine();
            int km = Convert.ToInt32(kmStr);
            car1.Drive(km);
            Console.WriteLine(car1.CurrentFuel);

        }

        static Notebook[] byPrice (double min, double max, Notebook[] arr) 
        
        {
            int count = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price >= min && arr[i].Price <= max)
                {
                    count++;    
                }
            }

            Notebook[] afterFiltr = new Notebook[count];

            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Price >= min && arr[i].Price <= max)
                {
                    afterFiltr[j] = arr[i];
                    j++;
                }
            }

            return afterFiltr;
        }
    }
}
