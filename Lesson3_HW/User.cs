﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson3_HW
{
    public class User
    {
        private string _firstName;
        private string _secondName;
        private int _age;
        private Gender _gender;



        public string Gender
        {
            get
            {
                return _gender.ToString();
            }
            set
            {
                value = value.ToString();
                bool isValidGender = Enum.TryParse(value, out Gender _gender) && Enum.IsDefined(typeof(Gender), value);

                if (!isValidGender)
                {
                    throw new ArgumentException("Please enter correct genger: Male (or 0), Female (or 1), or Mechanic (or 2).");
                }
                _gender = (Gender)Enum.Parse(typeof(Gender), value);


            }
        }

        public int Age
        {
            get { return _age; }
        }

        public User(int age)
        {
            _age = age;
            _gender = (Gender)Enum.Parse(typeof(Gender), "Mechanic");
        }

        public User()
        {
            _age = 0;
            _gender = (Gender)Enum.Parse(typeof(Gender), "Mechanic");
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                Regex template = new Regex("^[A-Z][a-z]*$");
                if (!template.IsMatch(value))
                {
                    throw new ArgumentException("Please enter correct First name.For example: Eudelme");
                }
                _firstName = value;
            }
        }
        public string SecondName
        {
            get { return _secondName; }
            set
            {
                Regex template = new Regex("^[A-Z][a-z]*$");
                if (!template.IsMatch(value))
                {
                    throw new ArgumentException("Please enter correct Second name.For example: Schønning");
                }
                _secondName = value;
            }

        }

        public override string ToString()
        {
            if (_age > 10)
            {
                return $"Hi, my name is {_firstName} {_secondName}. I am {_age} years old. I am {Gender}.";
            }
            else
            {
                return $"Hi, my name is {_firstName} {_secondName}. I am a baby. I am {Gender}.";
            }

        }

    }
}
