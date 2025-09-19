using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate first Employee object and set its properties
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Emp",
                LastName = "One"
            };

            // Instantiate second Employee object and set its properties
            Employee employee2 = new Employee
            {
                Id = 102,
                FirstName = "Emp",
                LastName = "Two"
            };

            // Compare the two Employee objects using the overloaded == operator
            // This will compare them by Id only
            bool areEqual = employee1 == employee2;

            // Display result of the comparison
            Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

            // Compare using the overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display result of the inequality comparison
            Console.WriteLine("Are employee1 and employee2 NOT equal? " + areNotEqual);

            // Keep the console open
            Console.ReadLine();
        }
    }
}
