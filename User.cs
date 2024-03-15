using System;
namespace DiscordBot
{
	public class User
	{
		public string Name { get; set; }
		public Server MyServer { get; set; }
		public Channel MyChannel { get; set; }
        public Roles Roles { get; set; }


        public User(string name, Server myServer, Channel myChannel)
        {
            Name = name;
            MyServer = myServer;
            MyChannel = myChannel;
            Roles = Roles.Kitten;
        }

        public void ToString()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Roles);
        }

    }
}


