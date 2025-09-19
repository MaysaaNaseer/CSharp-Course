using System;

namespace EmployeeInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of Employee and assign values
            Employee emp = new Employee
            {
                Id = 123,
                FirstName = "Alice",
                LastName = "Johnson"
            };

            // Use polymorphism: assign the Employee object to a variable of type IQuittable
            IQuittable quittable = emp;

            // Call the Quit method on the IQuittable object
            // This will invoke the Employee class's implementation of Quit()
            quittable.Quit();

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
