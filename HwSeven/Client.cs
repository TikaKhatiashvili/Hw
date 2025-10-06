using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwSeven;

public class Client
{
    private string _firstName;
    private string _lastName;
    private string _personalNumber;

    public string FirstName
    {
        get { return _firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                throw new ArgumentException("First name is required and max 50 characters.");
            _firstName = value;
        }
    }

    public string LastName
    {
        get { return _lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 50)
                throw new ArgumentException("Last name is required and max 50 characters.");
            _lastName = value;
        }
    }

    public string PersonalNumber
    {
        get { return _personalNumber; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 11)
                throw new ArgumentException("Personal number must be exactly 11 characters.");
            _personalNumber = value;
        }
    }

    public Account Account { get; set; }

    public Client(string firstName, string lastName, string personalNumber, Account account)
    {
        FirstName = firstName;
        LastName = lastName;
        PersonalNumber = personalNumber;
        Account = account;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Client: {FirstName} {LastName}, PersonalNumber: {PersonalNumber}, Account: {Account.AccountNumber}, Balance: {Account.Balance} {Account.Currency}");
    }
}
