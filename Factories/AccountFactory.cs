using OnBoardBank.Constants;
using OnBoardBank.Models;


namespace OnBoardBank.Factories
{
    internal static class AccountFactory
    {
        public static Account GenerateAccount(AccountType accountType, int accountNumber, int clientId, decimal startingBalance)
        {
            switch(accountType)
            {
                case AccountType.Chequing:
                    return new ChequingAccount(accountNumber, clientId, startingBalance);
                case AccountType.Savings:
                    return new SavingsAccount(accountNumber, clientId, startingBalance);
                default:
                    throw new ArgumentException("Cannot generate a new account, Account Type invalid!");
            }
        }
    }
}
