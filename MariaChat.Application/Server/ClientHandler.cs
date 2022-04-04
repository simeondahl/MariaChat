using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaChat.Domain.Server;

namespace MariaChat.Application.Server
{
    public class ClientHandler : IClientHandler
    {
        public event IClientHandler.OnClientConnected? ClientConnected;

        public void StartListen(int port)
        {
            var connectionThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    ClientConnected?.Invoke("Simeon");
                }
            });
            connectionThread.Start();
        }
    }
}
