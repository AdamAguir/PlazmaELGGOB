using Microsoft.AspNetCore.SignalR;
namespace PlazmaELGGOB.Hubs
{
    public class PointHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("receiveMessage", user, message);
        }
    }
}
