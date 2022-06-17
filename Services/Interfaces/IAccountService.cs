using OnBoardBank.Constants;
using OnBoardBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Services.Interfaces
{
    internal interface IAccountService
    {
        List<Account> AllAccounts { get; set; }
        int CreateAccount(int clientId, AccountType accountType, decimal startingBalance);
        int GenerateNewAccountNumber();
    }
}
