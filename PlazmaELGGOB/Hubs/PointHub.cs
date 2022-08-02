using Microsoft.AspNetCore.SignalR;
using PlazmaELGGOB.Model;
using System;
using System.Timers;

namespace PlazmaELGGOB.Hubs
{
    public class PointHub : Hub
    {
        private System.Timers.Timer aTimer;
        private int timeRemaning;
        public Task SendMessage(string user, string points)
        {
            return Clients.All.SendAsync("RecieveMessage", user, points);
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
