using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRAuth.Hubs
{
    [Authorize]
    public class TestHub : HubWithPresence
    {


        private readonly IUserTracker<TestHub> userTracker;
        public TestHub(IUserTracker<TestHub> userTracker)
            : base(userTracker)
        {
            this.userTracker = userTracker;
        }

        public override async Task OnConnectedAsync()
        {
           // await Clients.Client(Context.ConnectionId).SendAsync("SetUsersOnline", await GetUsersOnline());
            await base.OnConnectedAsync();
        }

        public override Task OnUsersJoined(UserDetails[] users)
        {
            return Clients.Client(Context.ConnectionId).SendAsync("UsersJoined", users);
        }

        public override Task OnUsersLeft(UserDetails[] users)
        {
            return Clients.Client(Context.ConnectionId).SendAsync("UsersLeft", users);
        }

        public async Task Send(string message)
        {
            await Clients.All.SendAsync("Send", Context.User.Identity.Name);
        }
        

    }


}

