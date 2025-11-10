using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyBank.Repository.Models;

namespace TinyBank.Repository.Interfaces;

public interface IAccountRepository
{
    List<Account> GetAccounts(int custId);
    Account GetSingleAccount(int id);
    int AddAccount(Account account);
    int UpdateAccount(Account account);
    int DeleteAccount(int id);
}
