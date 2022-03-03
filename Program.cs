using System;
using System.Collections.Generic;
using com.hr;
namespace CSClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager()
            {FirstName="Venkata", LastName="Ganduri", Salary=1000000,Filename="Employees.csv"};

            // foreach(Employee emp in manager.Employees)
            // {
            //     Console.WriteLine(emp.FirstName);
            //     Console.WriteLine(emp.Salary);
            //     Console.WriteLine(emp.LastName);
            // }

            List<Car> cars = new List<Car>();
            for(int i =0; i<32; i++)
            {
                cars.Add(new Car(){Assigned=false, ID=i});
            }
            int idx = new Random().Next(cars.Count);
            manager.CompanyCar = cars[idx];
            cars[idx].Assigned = true;
            Console.WriteLine(manager);
        }
    }
}