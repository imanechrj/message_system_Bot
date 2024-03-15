using System;
namespace DiscordBot
{
    public abstract class Bot : User
    {
        public static Dictionary<User, int> MessagesSent = new Dictionary<User, int>();

        public Bot(string name, Server myServer, Channel myChannel) : base(name, myServer, myChannel)
        {
        }

        public abstract void BotAbilities(Object? sender, PostArgs postArgs);
    }
}

