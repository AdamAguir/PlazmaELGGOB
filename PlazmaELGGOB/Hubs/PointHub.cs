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
        private System.Timers.Timer aTimer;
        private int timeRemaning;
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
        //public Task UpdateTimer(int timer)
        //{        
        //    return Clients.All.SendAsync("UpdateTimer", timer);
        //}

        //public void startTimer()
        //{
        //    timeRemaning = 60;
        //    //create timer at 1 second interval
        //    aTimer = new System.Timers.Timer(1000);
        //    aTimer.Elapsed += OnTimedEvent;
        //    aTimer.AutoReset = true;
        //    aTimer.Enabled = true;
        //}
        //private void OnTimedEvent(Object source, ElapsedEventArgs e)
        //{
        //    timeRemaning -= 1;
        //}

    }
}
