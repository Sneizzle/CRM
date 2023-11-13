using CRM.Shared.Model;
using Microsoft.AspNetCore.SignalR;

namespace CRM.Server.Hubs
{
    public class CustomerHub : Hub
    {
        public async Task SendCustomerCreated(Customer customer)
        {
            await Clients.All.SendAsync("ReceiveCustomer", customer);
        }
    }
}