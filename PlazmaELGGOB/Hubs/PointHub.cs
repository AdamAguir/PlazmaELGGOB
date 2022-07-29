using Microsoft.AspNetCore.SignalR;
using PlazmaELGGOB.Model;

namespace PlazmaELGGOB.Hubs
{
    public class PointHub : Hub
    {
        public Task SendMessage(string user, string points)
        {
            return Clients.All.SendAsync("RecieveMessage", user, points);
        }
    }
}
