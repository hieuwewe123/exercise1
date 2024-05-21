using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exercise1
{
    public class PartTimeEmployee : Employee
    {
        // khai bao bien
        private int workingHours;

        // Constructor 
        public PartTimeEmployee(string name, int paymentPerHour, int workingHours)
            : base(name, paymentPerHour)
        {
            this.workingHours = workingHours;
        }

        // Override ham calculateSalary to calculate the salary 
        public override int calculateSalary()
        {
            return workingHours * PaymentPerHour; 
        }

        // Override ham getName to return the name of the employee
        public override string getName()
        {
            return Name;
        }

        // ToString
        public override string ToString()
        {
            return $"{base.ToString()}, Working Hours: {workingHours}, Salary: {calculateSalary()}";
        }
    }
}
