using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApiSignalR.Hubs;

namespace WebApiSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private IHubContext<MessageHub, IMessageHubClient> messageHub;

        public OfferController(IHubContext<MessageHub, IMessageHubClient> messageHub)
        {
            this.messageHub = messageHub;
        }

        [HttpGet]
        public string Get()
        {
            string data = "1500.$";
            messageHub.Clients.All.SendOffersToUser(data);
            return "Offers were sent successfully!";
        }
    }
}
