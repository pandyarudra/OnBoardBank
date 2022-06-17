using OnBoardBank.Constants;
using OnBoardBank.Factories;
using OnBoardBank.Models;
using OnBoardBank.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Services
{
    internal class AccountService : IAccountService
    {
        private readonly IAccountService _accountService;

        public AccountService(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public List<Account> AllAccounts { get; set; } = new List<Account>();

        public int CreateAccount(int clientId, AccountType accountType, decimal startingBalance)
        {
            var newAccountNumber = GenerateNewAccountNumber();
            Account account = AccountFactory.GenerateAccount(accountType, newAccountNumber, clientId, startingBalance);
            AllAccounts.Add(account);

            return account.AccountNumber;
        }

        public int GenerateNewAccountNumber()
        {
            return AllAccounts.Last().AccountNumber + 1;
        }
    }
}
