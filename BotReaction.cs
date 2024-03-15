using System;
namespace DiscordBot
{
	public class BotReaction : Bot
	{
        public string Response { get; set; }

        public BotReaction(string name, Server myServer, Channel myChannel) : base(name, myServer, myChannel)
        {
            Response = "       _                        \n       \\`*-.                    \n        )  _`-.                 \n       .  : `. .                \n       : _   '  \\               \n       ; *` _.   `*-._          \n       `-.-'          `-.       \n         ;       `       `.     \n         :.       .        \\    \n         . \\  .   :   .-'   .   \n         '  `+.;  ;  '      :   \n         :  '  |    ;       ;-. \n         ; '   : :`-:     _.`* ;\n[bug] .*' /  .*' ; .*`- +'  `*' \n      `*-*   `*-*  `*-*'";
        }

        public override void BotAbilities(Object? sender, PostArgs postArgs)
        {
            if(postArgs.Content == "Cat")
            {
            Console.WriteLine(Response);
            }
        }
    }
}

