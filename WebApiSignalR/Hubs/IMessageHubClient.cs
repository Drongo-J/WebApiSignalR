namespace WebApiSignalR.Hubs
{
    public interface IMessageHubClient
    {
        Task SendOffersToUser(string message);
    }
}
    