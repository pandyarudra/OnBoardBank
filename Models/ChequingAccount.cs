using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Models
{
    public class ChequingAccount : Account
    {
        public ChequingAccount(int accountNumber, int clientId, decimal startingBalance) : base(accountNumber, clientId, startingBalance)
        {

        }
    }
}
