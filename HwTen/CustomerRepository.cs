using HwTen.Models;

namespace HwTen;

public class CustomerRepository
{
    private readonly string _filePath;

    public CustomerRepository(string filePath)
    {
        _filePath = filePath;
    }

    public List<Customer> GetAllCustomers()
    {
        if (!File.Exists(_filePath))
            throw new FileNotFoundException("File not found", _filePath);

        var lines = File.ReadAllLines(_filePath).ToList();
        lines.RemoveAt(0); 

        var customers = new List<Customer>();

        foreach (var line in lines)
        {
            var parts = line.Split(',', StringSplitOptions.TrimEntries);
            var customer = new Customer
            {
                CustomerId = int.Parse(parts[0]),
                FirstName = parts[1],
                LastName = parts[2],
                Email = parts[3],
                Phone = parts[4],
                City = parts[5]
            };
            customers.Add(customer);
        }

        return customers;
    }

    public Customer GetSingleCustomer(int customerId)
    {
        var customers = GetAllCustomers();
        foreach (var c in customers)
        {
            if (c.CustomerId == customerId)
                return c;
        }
        return null;
    }

    public int AddCustomer(Customer model)
    {
        var customers = GetAllCustomers();
        int newId = customers.Any() ? customers.Max(c => c.CustomerId) + 1 : 1;
        model.CustomerId = newId;

        string newLine = $"{model.CustomerId},{model.FirstName},{model.LastName},{model.Email},{model.Phone},{model.City}";
        File.AppendAllText(_filePath, "\n" + newLine);
        return model.CustomerId;
    }

    public int UpdateCustomer(Customer model)
    {
        var customers = GetAllCustomers();
        bool updated = false;

        for (int i = 0; i < customers.Count; i++)
        {
            if (customers[i].CustomerId == model.CustomerId)
            {
                customers[i] = model;
                updated = true;
                break;
            }
        }

        if (updated)
        {
            WriteAll(customers);
            return 1;
        }

        return 0;
    }

    public int DeleteCustomer(int customerId)
    {
        var customers = GetAllCustomers();
        int initialCount = customers.Count;

        customers = customers.Where(c => c.CustomerId != customerId).ToList();

        if (customers.Count < initialCount)
        {
            WriteAll(customers);
            return 1;
        }

        return 0;
    }

    private void WriteAll(List<Customer> customers)
    {
        var lines = new List<string> { "CustomerId,FirstName,LastName,Email,Phone,City" };

        foreach (var c in customers)
        {
            string line = $"{c.CustomerId},{c.FirstName},{c.LastName},{c.Email},{c.Phone},{c.City}";
            lines.Add(line);
        }

        File.WriteAllLines(_filePath, lines);
    }
}
