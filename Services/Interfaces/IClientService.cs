using OnBoardBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Services.Interfaces
{
    internal interface IClientService
    {
        List<Client> AllClients { get; set; }
        int AddClient(string firstName, string lastName);
        int GenerateClientNumber();
    }
}
