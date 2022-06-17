using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Models
{
    public class SavingsAccount: Account
    {
        public SavingsAccount(int accountNumber, int clientId, decimal startingBalance) : base(accountNumber, clientId, startingBalance)
        {

        }
    }
}
