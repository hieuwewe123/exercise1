using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class FullTimeEmployee : Employee
    {
        // Constructor 
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }
        // Override ham calculateSalary to calculate the salary
        public override int calculateSalary()
        {
            return 8 * PaymentPerHour; 
        }

        // Override ham getName to return the name of the employee
        public override string getName()
        {
            return Name;
        }

        // ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Full-Time Salary: {calculateSalary()}";
        }
    }
}
