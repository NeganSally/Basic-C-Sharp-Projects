using System; // Import System namespace for Console and basic types

// Define the Employee class
class Employee
{
    // Property for employee ID
    public int Id { get; set; }

    // Property for employee first name
    public string FirstName { get; set; }

    // Property for employee last name
    public string LastName { get; set; }

    // Overload the == operator to compare Employee objects by Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for null on both sides to avoid exceptions
        if (ReferenceEquals(emp1, null) && ReferenceEquals(emp2, null))
            return true;
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare based on Id property
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator to return the opposite of ==
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Override Equals() to avoid compiler warning (not strictly required for == overload)
    public override bool Equals(object obj)
    {
        // Attempt to cast obj to Employee
        if (obj is Employee otherEmp)
        {
            return this.Id == otherEmp.Id;
        }
        return false;
    }

    // Override GetHashCode() as best practice when Equals() is overridden
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}

// Entry point of the console application
class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object and assign values
        Employee employee1 = new Employee();
        employee1.Id = 101;
        employee1.FirstName = "Alice";
        employee1.LastName = "Smith";

        // Create the second Employee object and assign values
        Employee employee2 = new Employee();
        employee2.Id = 101; // Same ID as employee1
        employee2.FirstName = "Bob";
        employee2.LastName = "Johnson";

        // Compare the two employees using the overloaded == operator
        bool areEqual = employee1 == employee2;
        Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);

        // Compare using the overloaded != operator
        bool areNotEqual = employee1 != employee2;
        Console.WriteLine("Are employee1 and employee2 not equal? " + areNotEqual);
    }
}
