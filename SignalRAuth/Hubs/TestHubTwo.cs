using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAuth.Hubs
{
    public class TestHubTwo:Hub
    {
        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }

        public async Task Send(string username)
        {
            await Clients.All.SendAsync("send", username);
        }
    }
}
