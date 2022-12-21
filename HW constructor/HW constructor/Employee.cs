using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace HW_constructor
{
    internal class Employee:Human
    {
        public int Salary; //зарплата
        public string Position; //должность


        public Employee(string FullName, int Age) : base(FullName, Age)
        {

        }
        public void Info(string FullName, int age, int Salary, string Position)

        {
            Console.WriteLine($"FullName: {FullName} - Age: {Age} - Salary: {Salary} - Position: {Position}"); 
        }
      
           

    }
    }
}
