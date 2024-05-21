using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    // Abstract class 
    public abstract class Employee : IEmployee
    {
        // khai bao bien
        private String name;
        private int paymentPerHour;

        // Constructor 
        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        // getter and setter
        public string Name { get => name; set => name = value; }
        public int PaymentPerHour { get => paymentPerHour; set => paymentPerHour = value; }

        // Abstract method to calculate the salary
        public abstract int calculateSalary();

        // Abstract method to get the name
        public abstract string getName();

        // ToString
        public override string? ToString()
        {
            return $"Name: {Name}, Payment Per Hour: {PaymentPerHour}";
        }
    }
}
