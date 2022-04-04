using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MariaChat.Domain.Server;
namespace MariaChat.Application.Server
{
    public class ChatService : IChatService
    {
        private readonly IClientHandler _clientHandler;
        private readonly IMessageHandler _messageHandler;
        private readonly int _chatPort;

        public ChatService(int chatPort)
        {
            try
            {
                ServiceHandler.RegisterService<ClientHandler>();
                ServiceHandler.RegisterService<MessageHandler>();

                _clientHandler = ServiceHandler.GetService<ClientHandler>();
                _messageHandler = ServiceHandler.GetService<MessageHandler>();

                Console.WriteLine($"[ChatService] All services has been successfully registered...");
            }
            catch (Exception ex)
            {
                throw new Exception($"[ChatService] " + ex.Message);
            }

            _chatPort = chatPort;
        }

        public void StartChatService()
        {
            try
            {
                _clientHandler.StartListen(_chatPort);
                _clientHandler.ClientConnected += ClientConnected;
                Console.WriteLine($"[ChatService] Started to listen on port '{_chatPort}' for connections...");
            }
            catch (Exception ex)
            {
                throw new Exception($"[ChatService] " + ex.Message);
            }
        }

        private static void ClientConnected(string e)
        {
            Console.WriteLine($"[ClientHandler] Client '{e}' connected to the server.");

        }
    }
}
