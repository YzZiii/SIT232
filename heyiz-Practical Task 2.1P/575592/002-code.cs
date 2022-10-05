using System;

namespace Employee
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            //Create two employees with different salarles
            Employee Yi = new Employee("YIZHENG HE", 180000);
            Employee Amber = new Employee("Amber Zhao", 45000);

            //Test getting the name and salary
            Console.WriteLine("Employee Name: " + Yi.getName() +
                ", Salary: " + Yi.getSalary());
            Console.WriteLine("Employee Name: " + Amber.getName() +
                ", Salary: " + Amber.getSalary());


            //Test increasing the salary 
            Yi.raiseSalary(6.0);     
            Amber.raiseSalary(18.0); 

            Console.WriteLine();

            //additional employee 
            Employee Tom =new Employee("Tom", 12300);
            Console.WriteLine("Employee Name: " + Tom.getName() +
                ", Salary: " + Tom.getSalary());
    
            //Test  tax calculates correctly
            Console.WriteLine("Employee Name: " + Yi.getName() +
                ", Salary: " + Yi.Tax());   
            Console.WriteLine("Employee Name: " + Amber.getName() +
                ", Salary: " + Amber.Tax()); 
            Console.WriteLine("Employee Name: " + Tom.getName() +
                ", Salary: " + Tom.Tax());  
        }
    }
}
