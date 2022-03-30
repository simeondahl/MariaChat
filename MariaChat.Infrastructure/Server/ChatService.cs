using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaChat.Domain.Server;
namespace MariaChat.Infrastructure.Server
{
    public class ChatService : IChatService
    {
        private IClientHandler _clientHandler;
        private IMessageHandler _messageHandler;

        public void StartChatService()
        {
            throw new NotImplementedException();
        }
    }
}
