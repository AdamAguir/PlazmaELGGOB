using Microsoft.AspNetCore.SignalR;
using PlazmaELGGOB.Model;
using System;
using System.Timers;

namespace PlazmaELGGOB.Hubs
{

    public static class UserHandler
    {
        public static HashSet<string> ConnectedIds = new HashSet<string>();

        public static int getConnectedIdCount()
        {
            return ConnectedIds.Count;
        }
    }
    public class PointHub : Hub
    {
        
        public Task SendMessage(string user, string points)
        {
            return Clients.All.SendAsync("RecieveMessage", user, points);
        }

        public override Task OnConnectedAsync()
        {
            UserHandler.ConnectedIds.Add(Context.ConnectionId);

            Console.WriteLine("users connected " + UserHandler.ConnectedIds.Count);
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            UserHandler.ConnectedIds.Remove(Context.ConnectionId);

            Console.WriteLine("users disconnected " + UserHandler.ConnectedIds.Count);
            return base.OnDisconnectedAsync(exception);
        }
        
        public Task TimerCheck()
        {
            return Clients.All.SendAsync("StartTimer");
        }

    }
}
