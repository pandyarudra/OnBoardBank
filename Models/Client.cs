using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Models
{
    public class Client
    {
        public Client(int clientId, string firstName, string lastName)
        {
            ClientId = clientId;
            FirstName = firstName;
            LastName = lastName;
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Account> Accounts { get; set; } = new List<Account>();
    }
}
