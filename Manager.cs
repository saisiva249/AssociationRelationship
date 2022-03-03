using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace com.hr
{
    class Manager: Employee
    {
        public List<Employee> Employees
        {get; set;}
        public string filename;
        public string Filename
        {
            get{return filename;}
            set
            {
                filename = value;
                this.Employees = File.ReadAllLines(value)
                                    .Skip(1)
                                    .Select(line=>Employee.CSVToEmplyee(line))
                                    .ToList();
            }
        }
        public Car CompanyCar
        {get;set;}
        public override string ToString()=> "Manager "+ base.ToString() +"\n"+ string.Join("\n", Employees);

    }
}