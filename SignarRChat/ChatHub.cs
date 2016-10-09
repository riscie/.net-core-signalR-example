using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Hubs;

namespace SignarRChat
{
    [HubName("chatHub")]
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name + " (" + DateTime.Now.ToString("HH:mm:ss") + ")", message);
        }
    }
}