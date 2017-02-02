using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRConnectionLimitIssue.Hubs
{
    public class MessagingHub : Hub
    {
        [HubMethodName("sendOthers")]
        public void SendToOthers(string message)
        {
            Clients.All.ReceiveMessage(message);
        }
    }
}