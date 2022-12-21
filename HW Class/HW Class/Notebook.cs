using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Class
{
    internal class Notebook
    {
        public string Name;
        public string Brand;
        public double Price;

        public string GetInfo()

        {
            return $"Name: {Name} - Brand: {Brand} - Price: {Price}" ;
        }


    }
}
