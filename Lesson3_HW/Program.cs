using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Empty project");
    }
}

public class User
{
    private string _firstName;
    private string _secondName;

    public string FirstName
    { 
        get { return _firstName; } 
        set 
        {   
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name cannot be null or empty.");
            }
            _firstName = value;
        } 
    }
    public string SecondName 
    { 
        get { return _secondName; } 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("First name cannot be null or empty.");
            }
            _secondName = value;
        }
    }

}
