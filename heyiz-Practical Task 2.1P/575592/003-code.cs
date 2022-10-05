using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{   
   
    class Employee
    {
        // Instance variables
        private String name;
        private double salary;
       
        /// <summary>
        /// The class constructor
        /// </summary>
        /// <param name="employeeName"></param>
        /// <param name="currentSalary"></param>
        public Employee(String employeeName, double currentSalary)
        {
            this.name = employeeName;
            this.salary = currentSalary;
        }
        /// <summary>
        /// Returns the name of the employess
        /// </summary>
        /// <returns>
        /// The name pf the emplyee
        /// </returns>
        public String getName()
        {
            return this.name;
        }
        /// <summary>
        /// Returns the current salary of the employee
        /// </summary>
        /// <returns>
        /// The current salary of the emplyess as a string
        /// </returns>
        public String getSalary()
        {
            return this.salary.ToString("C");
        }
        /// <summary>
        /// Raises the current salary by a percentage
        /// </summary>
        /// <param name="percentRaise">The percent amount to add to  the salary</param>
        public void raiseSalary(double percentRaise)
        {
            this.salary = this.salary * (1.0 + (percentRaise / 100));
            Console.WriteLine("Current salary for " + getName() + "now" + getSalary());
        }

        public String Tax()
        {
            if (this.salary >= 180000)
            {
                double tax = 54096 + (0.45 * (this.salary - 180000));
                return tax.ToString("C");
            }
            else if (this.salary >90000)
            {
                double tax = 20797 + (0.37 * (this.salary - 90000));
                return tax.ToString("C");
            }
            else if (this.salary >37000)
            {
                double tax = 3572 + (0.325 * (this.salary - 37000));
                return tax.ToString("C");
            }
            else if (this.salary > 18200)
            {
                double tax = 0.18 * (this.salary - 18200);
                return tax.ToString("C");
            }
            else
            {
                return "Nil";
            }
        }
    }
}
