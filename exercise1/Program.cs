namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // khai bao list Employee
            List<Employee> employees = new List<Employee>();
            bool exit = false;
            //Menu
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Find Employee with Highest Salary (FullTime and PartTime)");
                Console.WriteLine("3. Find Employee by Name");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddEmployee(employees);
                        break;
                    case 2:
                        FindHighestSalary(employees);
                        break;
                    case 3:
                        FindEmployeeByName(employees);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        //ham add employee moi
        static void AddEmployee(List<Employee> employees)
        {
            try
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();

                Console.Write("Enter payment per hour: ");
                int paymentPerHour = int.Parse(Console.ReadLine());

                Console.WriteLine("Select employee type:");
                Console.WriteLine("1. Part-Time Employee");
                Console.WriteLine("2. Full-Time Employee");
                int employeeType = int.Parse(Console.ReadLine());

                switch (employeeType)
                {
                    case 1:
                        Console.Write("Enter working hours: ");
                        int workingHours = int.Parse(Console.ReadLine());
                        employees.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
                        break;
                    case 2:
                        employees.Add(new FullTimeEmployee(name, paymentPerHour));
                        break;
                    default:
                        Console.WriteLine("Invalid employee type.");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        }
        // ham tim luong cao nhat
        static void FindHighestSalary(List<Employee> employees)
        {
            Employee highestSalaryPartTime = null;
            Employee highestSalaryFullTime = null;

            foreach (Employee emp in employees)
            {
                if (emp is PartTimeEmployee)
                {
                    if (highestSalaryPartTime == null || emp.calculateSalary() > highestSalaryPartTime.calculateSalary())
                    {
                        highestSalaryPartTime = emp;
                    }
                }
                else if (emp is FullTimeEmployee)
                {
                    if (highestSalaryFullTime == null || emp.calculateSalary() > highestSalaryFullTime.calculateSalary())
                    {
                        highestSalaryFullTime = emp;
                    }
                }
            }

            Console.WriteLine("Part-Time Employee with Highest Salary:");
            if (highestSalaryPartTime != null)
            {
                Console.WriteLine(highestSalaryPartTime.ToString());
            }
            else
            {
                Console.WriteLine("No Part-Time Employees found.");
            }

            Console.WriteLine("Full-Time Employee with Highest Salary:");
            if (highestSalaryFullTime != null)
            {
                Console.WriteLine(highestSalaryFullTime.ToString());
            }
            else
            {
                Console.WriteLine("No Full-Time Employees found.");
            }
        }
        //tim nhan vien theo ten
        static void FindEmployeeByName(List<Employee> employees)
        {
            Console.Write("Enter employee name to search: ");
            string name = Console.ReadLine();
            bool found = false;

            foreach (Employee emp in employees)
            {
                if (emp.getName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(emp.ToString());
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No employee found with the given name.");
            }
        }
    }
}