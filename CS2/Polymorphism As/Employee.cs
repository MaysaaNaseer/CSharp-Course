using System;

namespace EmployeeInterfaceApp
{
    // Employee class inherits from IQuittable interface
    public class Employee : IQuittable
    {
        // Property for Employee Id
        public int Id { get; set; }

        // Property for First Name
        public string FirstName { get; set; }

        // Property for Last Name
        public string LastName { get; set; }

        // Implement the Quit() method from IQuittable
        public void Quit()
        {
            // Print a message to the console when Quit is called
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the company.");
        }

        // Optional: override ToString for convenience
        public override string ToString()
        {
            return $"{FirstName} {LastName}, ID: {Id}";
        }
    }
}
