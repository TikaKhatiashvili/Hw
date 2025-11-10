using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyBank.Repository.Models;

namespace TinyBank.Repository.Interfaces;

public interface IAccountRepository
{
    List<Account> GetAccounts();
    Account GetSingleAccount(int id);
    int AddAccount(Account customer);
    int UpdateAccount(Account customer);
    int DeleteAccount(int id);
}
