using Microsoft.AspNet.SignalR;

namespace ChapSiteWithSignalR
{
    public class SimpleChat : Hub
    {
        //Just a simple data structure to pass back and forth (messages can only receive one param)
        public class MessageDto
        {
            public string Message { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
        }

        public void SpamEveryone(MessageDto message)
        {
            // Call the addMessage method on all clients
            Clients.All.addMessage(message.Message, message.Name, message.Color ?? "#FFF");
        }
    }
}