using Microsoft.AspNetCore.SignalR;

namespace server
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Console.WriteLine($"Got a Send Message from {user}");
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task GetStats(string user)
        {
            Console.WriteLine($"Got a GetStats from {user}");
            await Clients.All.SendAsync("ReceiveStats", 12345);
        }

        public async Task UnInstall(string user, string message)
        {
            Console.WriteLine($" {user} wants to uninstall program");
            await Clients.All.SendAsync("RequestReceived", user, message);
        }
    }
}
