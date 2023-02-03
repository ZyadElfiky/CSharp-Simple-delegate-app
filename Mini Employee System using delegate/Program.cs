using System;

namespace Mini_Employee_System_using_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee[] {
                new Employee("Zyad",1,10000), 
                new Employee("samy",2,3000),
                new Employee("eyad",3,1050),
                new Employee("mazen",4,2000),
                new Employee("salem",5,7000),
                new Employee("sara",6,9000),
                new Employee("marwa",7,8000),
                new Employee("nader",8,5000),
                new Employee("ashraf",9,2500),
                new Employee("mahmoud",10,6000),
                new Employee("kaream",11,2000),
            };

            var report = new Report();
            report.ProcessEmployee(employees, "Employees with Salary Less Than 6000", e => e.salary < 6000);
            report.ProcessEmployee(employees, "Employees with Salary 6000+", e => e.salary > 6000);
            report.ProcessEmployee(employees, "Employees with Salary Between 1000 and 30000", e => e.salary >= 1000 && e.salary<=3000);
        }
        

    }
}
