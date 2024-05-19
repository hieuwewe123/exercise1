using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee(string name, int paymentPerHour)
            : base(name, paymentPerHour)
        {
        }

        public override int calculateSalary()
        {
            return 8 * PaymentPerHour; // Assuming a full-time employee works 8 hours a day
        }

        public override string getName()
        {
            return Name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Full-Time Salary: {calculateSalary()}";
        }
    }

}
