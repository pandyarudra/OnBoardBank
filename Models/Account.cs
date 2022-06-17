using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Models
{
    public abstract class Account
    {
        public Account(int accountNumber, int clientId, decimal startingBalance)
        {
            AccountNumber = accountNumber;
            ClientId = clientId;
            Balance = startingBalance;
        }
        public int AccountNumber { get; set; }
        public int ClientId { get; set; }
        
        public decimal Balance { get; set; }


    }
}
