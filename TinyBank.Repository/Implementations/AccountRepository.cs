using System.Text.Json;
using TinyBank.Repository.Interfaces;
using TinyBank.Repository.Models;

namespace TinyBank.Repository.Implementations;

public class AccountRepository : IAccountRepository
{
    private readonly string _filePath;
    private readonly List<Account> _accounts;

    public AccountRepository(string filePath)
    {
        _filePath = filePath;
        _accounts = LoadData();

    }
    public List<Account> GetAccounts(int custId) => _accounts.Where(a => a.CustomerId == custId).ToList();
    public Account GetSingleAccount(int id) => _accounts.FirstOrDefault(a => a.Id == id);


    public int AddAccount(Account newAccount)
    {
        newAccount.Id = _accounts.Any() ? _accounts.Max(c => c.Id) + 1 : 1;
        _accounts.Add(newAccount);
        SaveData();
        return newAccount.Id;
    }

    public int DeleteAccount(int id)
    {
        var acount = _accounts.FirstOrDefault(c => c.Id == id);
        _accounts.Remove(acount);
        SaveData();
        return acount.Id;
    }

   
    public int UpdateAccount(Account account)
    {
        var index = _accounts.FindIndex(c => c.Id == account.Id);
        if (index >= 0)
        {
            _accounts[index] = account;
            SaveData();
        }
        return account.Id;
    }

    #region helpers
    //წაკითხვა
    private List<Account> LoadData()
    {
        if (!File.Exists(_filePath))
            return new List<Account>();
        var accounts=FromJson(File.ReadAllText(_filePath));
        return accounts?? new List<Account>();
        //გრძელი ჩანაწერი
        //if (accounts==null)
        // {
        //      return new List<Account>();
        // }
        //return accounts;
    }

    private List<Account> FromJson(string line)=>JsonSerializer.Deserialize<List<Account>>(line, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }); 

    //ჩაწერა
    private String ToJson(List<Account> accounts) => 
        JsonSerializer.Serialize(accounts,new JsonSerializerOptions { WriteIndented=true});
  
    private void SaveData() =>
        File.WriteAllText(_filePath, ToJson(_accounts));
    #endregion
}
