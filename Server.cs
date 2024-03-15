using System;
namespace DiscordBot
{
	public class Server
	{
		public string Name { get; set; }
        public List<Channel> Channels { get; set; }

        public Server(string name)
        {
            Name = name;
            Channels = new List<Channel>();
        }
    }
}

