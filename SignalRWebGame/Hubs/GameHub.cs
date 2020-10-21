using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRWebGame.Hubs
{
    public class GameHub : Hub
    {
        public async Task MoveBall(string y, string x)
        {
            await Clients.All.SendAsync("moved", y, x);
        }
    }
}
