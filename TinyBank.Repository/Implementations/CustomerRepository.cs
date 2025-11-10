using TinyBank.Repository.Interfaces;
using TinyBank.Repository.Models;

namespace TinyBank.Repository.Implementations;

public class CustomerRepository : ICustomerRepository
{
    private readonly string _filePath;
    private readonly List<Customer> _customers;

    public CustomerRepository(string filePath)
    {
        _filePath = filePath;
        _customers = LoadData();
    }
    public int AddCustomer(Customer newCustomer)
    {
        newCustomer.Id = _customers.Any() ? _customers.Max(c => c.Id) + 1 : 1;
        _customers.Add(newCustomer);
        SaveData();
        return newCustomer.Id;
    }

    public int DeleteCustomer(int id)
    {
        var customer = _customers.FirstOrDefault(c => c.Id == id);
        _customers.Remove(customer);
        SaveData();
        return customer.Id;
    }

    public List<Customer> GetCustomers()
    {
        return _customers;
    }

    public Customer GetSingleCustomer(int id) => _customers.FirstOrDefault(c => c.Id == id);

    public int UpdateCustomer(Customer customer)
    {
        var index = _customers.FindIndex(c => c.Id == customer.Id);
        if (index >= 0)
        {
            _customers[index] = customer;
            SaveData();
        }
        return customer.Id;
    }

    #region helpers
    //წაკითხვა
    private List<Customer> LoadData()
    {
        if (!File.Exists(_filePath))
            return new List<Customer>();
        var customers = new List<Customer>();
        var lines = File.ReadAllLines(_filePath);
        if (lines.Length <= 1)
            return customers;
        //სათაურის გამოტოვება, 1 ინდექსიდან იწყებს
        for (int i = 0; i < lines.Length; i++)
        {
            var customer = FromCsv(lines[i]);
            if (customer != null)
                customers.Add(customer);
        }
        return customers;
    }
    private Customer FromCsv(string customer)
    {
        var separatedCustomer = customer.Split(',', StringSplitOptions.RemoveEmptyEntries);
        Customer result = new();
        if (separatedCustomer.Length != 6)
            throw new FormatException("Customer format is invalid");
        result.Id = int.Parse(separatedCustomer[0]);
        result.Name = separatedCustomer[1];
        result.IdentityNumber = separatedCustomer[2];
        result.PhoneNumber = separatedCustomer[3];
        result.Email = separatedCustomer[4];
        result.CustomerType = Enum.Parse<CustomerType>(separatedCustomer[5]);
        return result;
    }
    //ჩაწერა
    private void SaveData()
    {
        var lines = new List<string>
        {
            "Id,Name,IdentityNumber,PhoneNumber,Email,CustomerType"
        };
        foreach (var customer in _customers)
        {
            lines.Add(ToCsv(customer));
        }
        File.WriteAllLines(_filePath, lines);
    }
    private string ToCsv(Customer customer)
    {
        return $"{customer.Id},{customer.Name},{customer.IdentityNumber},{customer.PhoneNumber},{customer.Email},{customer.CustomerType}";
    }

    #endregion
}
