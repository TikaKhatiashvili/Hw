using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwSeven;

public class Human

{

    private string _firstName; 

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (value == null || value.Trim().Length == 0)
            {
                throw new ArgumentException("First name is required.");
            }
            if (value.Length > 50)
            {
                throw new ArgumentException("First name must be at most 50 characters.");
            }

            _firstName = value; 
        }
    }

    private string _lastName; 

    public string LastName
    {
        get { return _lastName; } 
        set
        {
            if (value == null || value.Trim() == "")
            {
                throw new ArgumentException("Last name is required."); 
            }

            if (value.Length > 50)
            {
                throw new ArgumentException("Last name must be at most 50 characters.");
            }

            _lastName = value;
        }
    }


    private byte _age; 

    public byte Age
    {
        get { return _age; } 
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be a positive number.");
            }

            _age = value;
        }
    }

    private string _personalNumber;

    public string PersonalNumber
    {
        get { return _personalNumber; }  
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Personal number is required.");
            }

            if (value.Length != 11)
            {
                throw new ArgumentException("Personal number must be exactly 11 characters.");
            }

            _personalNumber = value;
        }
    }



    private string _phoneNumber; 

    public string PhoneNumber
    {
        get { return _phoneNumber; }
        set
        {
            if (value == null || value == "") 
            {
                throw new ArgumentException("PhoneNumber is required!");
            }
            if (value.Length != 9)
            {
                throw new ArgumentException("PhoneNumber must be exactly 9 characters!");
            }

            _phoneNumber = value;
        }
    }


    private string _email;
    public string Email
    {
        get { return _email; }
        set
        {
            if (value == null || value == "") 
            {
                throw new ArgumentException("Email is required!");
            }

            if (!value.Contains("@"))
            {
                throw new ArgumentException("Email must contain the '@' symbol!");
            }

            if (value.StartsWith("@") || value.EndsWith("@"))
            {
                throw new ArgumentException("Email should not start or end with '@'!");
            }

            if (value.Contains(".@")) 
            {
                throw new ArgumentException("In an email, the '.' should not come before the '@'!");
            }

            _email = value;
        }
    }



    public Human(string firstName, string lastName, byte age, string personalNumber, string phoneNumber, string email)

    {

        FirstName = firstName;

        LastName = lastName;

        Age = age;

        PersonalNumber = personalNumber;

        PhoneNumber = phoneNumber;

        Email = email;

    }


    public void DisplayInfoInConsole()

    {

        Console.WriteLine($" Hello my name is {FirstName} {LastName} ,my age is {Age} , also my personal number is {PersonalNumber}, also my phone number is {PhoneNumber} and my email address is {Email}");

    }

}