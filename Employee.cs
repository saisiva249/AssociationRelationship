using System;
namespace com.hr
{
    class Employee: IComparable<Employee>
    {
        public string FirstName
        {set; get;}

        public string LastName
        {get; set;}

        public decimal Salary
        {get;set;}

        public int CompareTo(Employee obj)
        {
            if(obj==null) return 1;
            return this.Salary.CompareTo(obj.Salary);
        }
        public static Employee CSVToEmplyee(string csv)
        {
            string[] tokens = csv.Split(",");
            Employee emp = new Employee();
            emp.FirstName = tokens[0];
            emp.LastName = tokens[1];
            emp.Salary = Convert.ToDecimal(tokens[2]);
            return emp;
        }

        public override string ToString()=>"Employee [firstname="
        + FirstName+ ", lastname="+LastName+", salary="+Salary+"]";
    }
}