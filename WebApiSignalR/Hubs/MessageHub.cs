using Microsoft.AspNetCore.SignalR;

namespace WebApiSignalR.Hubs
{
    public class MessageHub : Hub<IMessageHubClient>
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }

        public async Task SendOffersToUser(string message)
        {
            await Clients.All.SendOffersToUser(message);
        }
    }
}
