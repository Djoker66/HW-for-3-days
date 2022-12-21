using System;

namespace HW_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car()
            {
                CurrentFuel = 20,
                FuelCapacity = 50
            };

            Console.WriteLine("Nece litr benzin elave etmek isteyirsiniz?");
            string fuelStr = Console.ReadLine();
            int fuel = Convert.ToInt32(fuelStr);
            car1.AddFuel(fuel);
            Console.WriteLine("Indi mawinda " + car1.CurrentFuel + " litr var ");

            Human human1 = new Human("Abbasov Hikmet", 30)
            {

            };

            //Employee employee1 = new Employee("Abbasov Hikmet", 30)
            //{
            //    Position = "Satici",
            //    Salary = 500
            //};

            //Employee employee2 = new Employee("Abbasov Hikmet", 30)
            //{
            //    Position = "Satici",
            //    Salary = 500
            //};

            

            Console.WriteLine("Say daxil edin");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);


            Employee[] employees = new Employee[count] ; //4 name, age, position, salary

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("FullName daxil edin: ");
                string FullName = Console.ReadLine();
                FullName += employees[i];

                Console.WriteLine("Age daxil edin: ");
                string agestr = Console.ReadLine();
                int Age = Convert.ToInt32(agestr);
                
                Console.WriteLine("Salary daxil edin: ");
                string salarystr = Console.ReadLine();
                int Salary = Convert.ToInt32(salarystr);

                Console.WriteLine("Position daxil edin: ");
                string Position = Console.ReadLine();
                Position += employees[i];

            }

            employees.Info(employees);
            Console.WriteLine(employees);

            bool input = false;
            do
            {
                Console.WriteLine("Axtariw etmek isteyirsinizmi?");
                string inputStr = Console.ReadLine();
                char inp = Convert.ToChar(inputStr);

                if (inp == 'y')
                {
                    Console.WriteLine("Axtaris deyerini yaz");
                    string word = Console.ReadLine();
                    input = true;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == employees[].FullName)
                        {
                            Console.WriteLine(employees[].FullName);
                        }
                        else
                        {
                            Console.WriteLine("Ele deyerle bir ad yoxdu");
                        }
                    }
                    
                }
                else if (inp == 'n')
                {
                    Console.WriteLine("Proces bitdi");
                    input = true;
                }

            }
            while (input = false);
           

        }
    }
}
