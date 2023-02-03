using System;


namespace Mini_Employee_System_using_delegate
{
    class Report
    {
        
        public delegate bool ProssesSalary(Employee e);

        public void ProcessEmployee(Employee[] employees,string title ,ProssesSalary process)
        {
            Console.WriteLine(title+"\n");
            foreach (var e in employees)
            {
                if (process(e))
                {
                    Console.WriteLine($"Name : {e.name} | id : {e.id} | Salary : {e.salary}");
                }
               
            }
            Console.WriteLine("\n\n");

        }
    }
}
