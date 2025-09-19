using System; // Importing the System namespace to use built-in classes like Console

namespace MathConsoleApp
{
    // Define a class named 'MathOperations'
    class MathOperations
    {
        // Define a void method that takes two integers as parameters
        public void DoMath(int num1, int num2)
        {
            // Perform a math operation on the first number (e.g., square it)
            int result = num1 * num1;

            // Display the result of the operation on the first number
            Console.WriteLine("The square of the first number is: " + result);

            // Display the second number to the console
            Console.WriteLine("The second number is: " + num2);
        }
    }

    // Define the main class containing the Main method
    class Program
    {
        // The entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the method using positional arguments
            // First number is 5, second number is 10
            mathOps.DoMath(5, 10);

            // Call the method using named parameters
            // Specifying parameter names explicitly for clarity
            mathOps.DoMath(num1: 3, num2: 7);

            // Prevent the console window from closing immediately
            Console.ReadLine();
        }
    }
}
