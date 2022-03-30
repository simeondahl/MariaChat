using MariaChat.Infrastructure;
using MariaChat.Infrastructure.Server;

try
{
    ServiceHandler.RegisterService<ChatService>();
    Console.WriteLine("Successfully registered the ChatService...");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
