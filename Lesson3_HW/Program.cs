﻿using Lesson3_HW;
using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;



class Program
{
    private static void Main(string[] args)
    {
        User user1 = new User(19);
        UserInput("Enter your gender Male (or 0), Female (or 1), or Mechanic (or 2). :", input => user1.Gender = input);
        UserInput("Enter your first name:", input => user1.FirstName = input);
        UserInput("Enter your second name:", input => user1.SecondName = input);

        Console.WriteLine(user1);

    }
    public static void UserInput(string Message, Action<string> setInput)
    {
        bool enterError;
        do
        {
            enterError = false;
            try
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine();
                if (input != null)
                {
                    setInput(input);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                enterError = true;
                
            }
        } while (enterError);
    }
}


