
using System;
using ProjectNoName.Contracts;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ProjectNoName.SerialDriverWorker {
    public class ClockHub : Hub<IClock>
    {
        public async Task SendTimeToClients(DateTime dateTime)
        {
            await Clients.All.ShowTime(dateTime);
        }
    }

}