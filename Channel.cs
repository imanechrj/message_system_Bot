using System;
using System.Reflection.Metadata;

namespace DiscordBot
{
	public class Channel
	{
		public string Name { get; set; }
        public Server Server { get; set; }
        public List<Message> Messages { get; set; }
        public event EventHandler<PostArgs> OnPost;

        public Channel(string name, Server server)
        {
            Name = name;
            Server = server;
            Messages = new List<Message>(); ;

            Server.Channels.Add(this);
        }

        public void Post(User userSender, Message message)
        {
            PostArgs postArgs = new(userSender, message.Content);
            OnPost.Invoke(this, postArgs);

            Messages.Add(message);

            if (Bot.MessagesSent.ContainsKey(userSender))
            {
                Bot.MessagesSent[userSender]++;
            }
            else
            {
                Bot.MessagesSent.Add(userSender, 0);
                Bot.MessagesSent[userSender]++;
            }
        }
    }
}

