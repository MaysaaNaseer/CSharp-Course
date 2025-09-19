using System;

namespace EmployeeInterfaceApp
{
    // Define an interface named IQuittable
    // It contains a method signature for Quit()
    public interface IQuittable
    {
        void Quit(); // Method that must be implemented by any class that inherits this interface
    }
}
