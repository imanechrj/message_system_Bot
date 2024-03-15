using System;
using System.Runtime.Intrinsics.X86;

namespace DiscordBot
{
	public class Message
	{
		public User UserSender { get; set; }
		public string Content { get; set; }
		public Channel Channel { get; set; }


        public Message(User userSender, string content, Channel channel)
        {
            UserSender = userSender;
            Content = content;
            Channel = channel;
        }

        public void ToString()
        {
            Console.WriteLine("Server : " + Channel.Server.Name);
            Console.WriteLine("Channel : "+ Channel.Name);
            Console.WriteLine(Content + "\n");
        }
    }
}

