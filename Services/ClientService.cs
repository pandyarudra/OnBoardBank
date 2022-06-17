using OnBoardBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBoardBank.Services.Interfaces
{
    internal class ClientService : IClientService
    {
        private readonly IClientService _clientService;
        public ClientService(IClientService clientService)
        {
            _clientService = clientService;
        }

        public List<Client> AllClients { get; set; } = new List<Client>();

        public int AddClient(string firstName, string lastName)
        {
            var clientId = GenerateClientNumber();
            var client = new Client(clientId, firstName, lastName);
            AllClients.Add(client);

            return clientId;
        }

        public int GenerateClientNumber()
        {
            return AllClients.Last().ClientId + 1;
        }
    }
}
