using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaChat.Domain.Server
{
    public interface IClientHandler
    {
        // Events
        public event OnClientConnected ClientConnected;
        
        // Functions
        public void StartListen(int port);

        // Delegates
        public delegate void OnClientConnected(string id);
    }
}
