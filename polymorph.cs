using System; // Importing the System namespace to use basic functionality like Console

// Define an interface named IQuittable
interface IQuittable
{
    // Declare a void method signature called Quit
    void Quit();
}

// Define a class named Employee that implements the IQuittable interface
class Employee : IQuittable
{
    // Properties for the Employee's first and last name
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method required by the IQuittable interface
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}

// Program entry point
class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object and assign values to its properties
        Employee emp = new Employee();
        emp.FirstName = "Jane";
        emp.LastName = "Doe";

        // Use polymorphism: create an object of type IQuittable and assign the Employee to it
        IQuittable quittableEmp = emp;

        // Call the Quit method through the interface reference
        quittableEmp.Quit(); // Output: Jane Doe has quit the job.
    }
}
