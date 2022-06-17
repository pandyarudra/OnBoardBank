using Microsoft.Extensions.DependencyInjection;
using OnBoardBank.Constants;
using OnBoardBank.Models;
using OnBoardBank.Services;
using OnBoardBank.Services.Interfaces;

var serviceProvider = new ServiceCollection()
    .AddScoped<IAccountService, AccountService>()
    .AddScoped<IClientService, ClientService>()
    .BuildServiceProvider();

// client code -> 

var clientServiceInstance = serviceProvider.GetService<IClientService>();
var accountServiceInstance = serviceProvider.GetService<IAccountService>();

var clientService = new ClientService(clientServiceInstance);
var clientId = clientService.AddClient("John", "Doe");

var accountService = new AccountService(accountServiceInstance);
var account = accountService.CreateAccount(clientId, AccountType.Chequing, (decimal)153.65);