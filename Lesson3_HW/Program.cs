using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;



class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User(19);
        bool enterError = false;


        do
        {
            enterError = false;
            try
            {
                Console.WriteLine("Enter your gender Male (or 0), Female (or 1), or Mechanic (or 2). :");
                user1.Gender = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                enterError = true;
            }

        } while (enterError);

        do
        {
            enterError = false;
            try
            {
                Console.WriteLine("Enter your first name:");
                user1.FirstName = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                enterError = true;
            }

        } while (enterError);

        do
        {
            enterError = false;
            try
            {
                Console.WriteLine("Enter your second name:");
                user1.SecondName = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                enterError = true;
            }

        } while (enterError);

        Console.WriteLine(user1);

    }
}


