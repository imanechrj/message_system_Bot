using System;
namespace DiscordBot
{
	public class PostArgs : EventArgs
	{
        public User UserSender { get; set; }
        public string Content { get; set; }

        public PostArgs(User userSender, string content)
        {
            UserSender = userSender;
            Content = content;
        }
    }
}

