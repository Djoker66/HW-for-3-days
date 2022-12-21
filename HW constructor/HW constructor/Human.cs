using System;
using System.Collections.Generic;
using System.Text;

namespace HW_constructor
{
    internal class Human 
    {
        public string FullName;
        public int Age;

        public Human(string FullName, int Age) 
        { 
         this.FullName = FullName;
         this.Age = Age;
        }
    }
}
