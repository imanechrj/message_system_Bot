using System.Reflection;

namespace DiscordBot;

class Program
{
    static void Main(string[] args)
    {
        
        Server potichats = new("PotitChats");
        Channel Patounes = new("Patounes", potichats);

        User user1 = new User("Imane", potichats, Patounes);
        User user2 = new User("Amel", potichats, Patounes);

        Message message1 = new(user2, "Hello", Patounes);
        Message message2 = new(user1, "Cat", Patounes);

        Bot botReaction = new BotReaction("Reaction Bot", potichats, Patounes);
        Bot botRole = new BotRole("Role Bot", potichats, Patounes);


        Patounes.OnPost += botReaction.BotAbilities;
        Patounes.OnPost += botRole.BotAbilities;


        message1.ToString();
        Patounes.Post(user2, message1);

        message2.ToString();
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        Patounes.Post(user1, message1);
        user1.ToString();
        message2.ToString();




    }
}