using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public abstract class Employee : IEmployee
    {
        private String name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public string Name { get => name; set => name = value; }
        public int PaymentPerHour { get => paymentPerHour; set => paymentPerHour = value; }

        public abstract int calculateSalary();
        public abstract string getName();

        public override string? ToString()
        {
            return $"Name: {Name}, Payment Per Hour: {PaymentPerHour}";
        }
    }
}
