using System;
namespace DiscordBot
{
    public class BotRole : Bot
    {

        public BotRole(string name, Server myServer, Channel myChannel) : base(name, myServer, myChannel)
        {
        }


        public override void BotAbilities(object? sender, PostArgs postArgs)
        {
            if (Bot.MessagesSent.ContainsKey(postArgs.UserSender))
            {

                switch (Bot.MessagesSent[postArgs.UserSender])
                {
                    case 2:
                        postArgs.UserSender.Roles = Roles.YoungCat;
                        Console.WriteLine("Your role is upgraded to Young Cat \n");
                        break;

                    case 4:
                        postArgs.UserSender.Roles = Roles.AdultCat;
                        Console.WriteLine("Your role is upgraded to Adult Cat \n");
                        break;

                    case 6:
                        postArgs.UserSender.Roles = Roles.CatSenior;
                        Console.WriteLine("Your role is upgraded to Cat Senior \n");

                        break;

                    case 8:
                        postArgs.UserSender.Roles = Roles.OldOldCat;
                        Console.WriteLine("Your role is upgraded to Old Old Cat \n");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

